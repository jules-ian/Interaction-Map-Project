const path = require("path");
const webpack = require("webpack");
const MiniCssExtractPlugin = require("mini-css-extract-plugin");

const ROOT = path.resolve(__dirname, "src");
const DESTINATION = path.resolve(__dirname, "src");

module.exports = function (_env, argv) {
    const isProduction = argv.mode === "production";
    const isDevelopment = !isProduction;

    return {
        context: ROOT,
        entry: {
            MyApp: "../src/index.js",
        },

        output: {
            filename: "myapp.bundle.js",
            path: DESTINATION,
        },
        module: {
            rules: [
                {
                    test: /\.(jsx|js)$/,
                    exclude: /node_modules/,
                    use: [
                        {
                            loader: "babel-loader",
                            options: {
                                presets: [
                                    "@babel/preset-env",
                                    ["@babel/preset-react", { "runtime": "automatic" }]
                                ]
                            },
                        },
                    ],
                },
                {
                    test: /\.css$/i,
                    use: [
                        isProduction ? MiniCssExtractPlugin.loader : "style-loader",
                        "css-loader",
                    ],
                },
                {
                    test: /\.(png|jpg|gif)$/i,
                    use: {
                        loader: "url-loader",
                        options: {
                            limit: 8192,
                            name: "static/media/[name].[hash:8].[ext]",
                        },
                    },
                },
                {
                    test: /\.svg$/,
                    use: ["@svgr/webpack", "url-loader"],
                },
            ],
        },
        resolve: {
            extensions: [".js", ".jsx"],
        },
        plugins: [
            // fix "process is not defined" error:
            // (do "npm install process" before running the build)
            isProduction &&
            new MiniCssExtractPlugin({
                filename: "assets/css/[name].[contenthash:8].css",
                chunkFilename: "assets/css/[name].[contenthash:8].chunk.css",
            }),

            new webpack.ProvidePlugin({
                process: "process/browser",
            }),
        ].filter(Boolean),
    };
};

//stats.errorDetails: true