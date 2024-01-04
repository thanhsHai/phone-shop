const User = require("../models/User");
const bcrypt = require("bcrypt");

const authController = {
    //REGISTER
    registerUser: async (req, res) => {
        try {
            const existingUser = await User.findOne({
                $or: [{ username: req.body.userName }, { email: req.body.email }],
            });
            

            if (existingUser) {
                return res.status(400).json({
                    success: false,
                    message: 'Username or email already exists',
                    data: {},
                });
            }
            console.log("Found existing user:", existingUser);

            console.log(req.body); // Log the entire request body to see what data you have
            console.log(req.body.userPassword);
            if (!req.body.userPassword) {
                return res.status(400).json({
                    success: false,
                    message: 'Password is required',
                    data: {},
                });
            }
            console.log("Password received:", req.body.userPassword);
            const salt = await bcrypt.genSalt(10);
            const hashed = await bcrypt.hash(req.body.userPassword, salt);

            //Create new user
            const newUser = await new User({
                name: req.body.name,
                userName: req.body.userName,
                email: req.body.email,
                userPassword: hashed,
            });

            //Save user to DB
            const user = await newUser.save();

            const { userPassword, ...others } = user._doc;

            res.status(200).json({
                success: true,
                message: 'Register successfully !',
                data: others
            });
        } catch (err) {
            console.log(err);
            if (err.code === 11000) {
                res.status(400).json({
                    success: false,
                    message: 'A user with that username or email already exists.',
                    data: {}
                });
            } else {
                res.status(500).json({
                    success: false,
                    message: 'Internal Server Error',
                    data: {}
                });
            }
        }
    },

    //LOGIN
    loginUser: async (req, res) => {
        try {
            const user = await User.findOne({
                $or: [{ email: req.body.emailOrUsername }, { username: req.body.emailOrUsername }]
            });

            if (!user) {
                return res.status(404).json({
                    success: false,
                    message: "Incorrect email",
                    data: {}
                });
            }

            const validPassword = await bcrypt.compare(
                req.body.userPassword,
                user.userPassword
            );

            if (!validPassword) {
                return res.status(404).json({
                    success: false,
                    message: "Incorrect password",
                    data: {}
                });
            }

            if (user && validPassword) {
                const { userPassword, ...others } = user._doc;

                return res.status(200).json({
                    success: true,
                    message: "Login successfully !",
                    data: others
                });
            }
        } catch (err) {
            return res.status(500).json({
                success: false,
                message: "Internal Server Error",
                data: {}
            });
        }
    },

    // LOG OUT
     logOut: async (req, res) => {
        //Clear cookies when user logs out
         refreshTokens = refreshTokens.filter((token) => token !== req.body.token);
         res.clearCookie("refreshToken");
         res.status(200).json("Logged out successfully!");
     }
};

module.exports = authController;