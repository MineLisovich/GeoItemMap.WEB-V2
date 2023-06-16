const path = require('path');
const autoprefixer = require('autoprefixer');
const bundleFolder = "wwwroot/bundle/";
module.exports = {

    mode: 'development',
    entry:
    {
        JSModul: ["./wwwroot/js/header.js", "./wwwroot/js/sidebarmap.js", "./wwwroot/js/bootstrap.bundle.min.js", "./wwwroot/js/jquery.js"],
        ScssModul: './wwwroot/js/app.js'
    },

       
    output: {
        filename: '[name].bundle.js',
        path: path.resolve(__dirname, bundleFolder),
    },
    module: {
        rules: [
            {
                test: /\.css$/,
                use: ['style-loader', 'css-loader'],
            },
            {
                test: /\.(scss)$/,
                use: [
                    {
                        loader: 'style-loader'
                    },
                    {
                        loader: 'css-loader'
                    },
                    {
                        loader: 'postcss-loader',
                        options: {
                            postcssOptions: {
                                plugins: () => [
                                    autoprefixer
                                ]
                            }
                        }
                    },
                    {
                        loader: 'sass-loader'
                    }
                ]
            }
        ]
    },
    optimization: {
        minimize: true
    }
};

