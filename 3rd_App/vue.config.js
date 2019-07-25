module.exports = {
	filenameHashing: false,
	productionSourceMap: false,
	integrity: false,
	outputDir: '../Assets',
	chainWebpack: config => {
		config.plugins.delete('html')
		config.plugins.delete('preload')
		config.plugins.delete('prefetch')
	}
}