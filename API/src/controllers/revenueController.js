const Order = require('../models/Order ');
const Product = require('../models/Product');

const revenueController = {
    getRevenueByDate: async (req, res) => {
        try {
            const { start, end } = req.body;

            const orders = await Order.find({
                date: {
                    $gte: start,
                    $lte: end,
                },
            });

            const revenueByDate = {};

            for (const order of orders) {
                // Tìm sản phẩm tương ứng
                const product = await Product.findOne({ name: order.productName });

                // Nếu tìm thấy sản phẩm, thêm doanh thu vào mảng theo ngày
                if (product) {
                    const orderDate = order.date;

                    if (!revenueByDate[orderDate]) {
                        revenueByDate[orderDate] = 0;
                    }

                    revenueByDate[orderDate] += order.quantity * product.price;
                }
            }

            const result = Object.entries(revenueByDate).map(([date, revenue]) => ({
                revenue
            }));

            res.status(200).json({
                success: true,
                message: "Get revenue successfully!",
                data: result,
            });
            console.log(result);
        } catch (error) {
            res.status(500).json({
                success: false,
                message: error.message,
                data: {},
            });
        }
    },
    getRevenueByYear: async (req, res) => {
        try {
            const { year } = req.body;

            const startDate = new Date(`01-01-${year}`);
            const endDate = new Date(`31-12-${year}`);


            const orders = await Order.find({
                date: {
                    $gte: startDate,
                    $lte: endDate,
                },
            });


            const totalRevenue = await orders.reduce(async (accPromise, order) => {
                const acc = await accPromise;

                // Tìm sản phẩm tương ứng
                const product = await Product.findOne({ name: order.productName });
                // console.log(product);
                // Nếu tìm thấy sản phẩm, thêm doanh thu
                if (product) {
                    return acc + (order.quantity * product.price);
                } else {
                    // Nếu không tìm thấy sản phẩm, trả về giá trị hiện tại của tổng doanh thu
                    return acc;
                }
            }, Promise.resolve(0));

            res.status(500).json({
                success: true,
                message: "Get revenue successfully !",
                data: totalRevenue
            });

        } catch (error) {
            res.status(500).json({
                success: false,
                message: err.message,
                data: {}
            });
        }
    }
}

module.exports = revenueController;