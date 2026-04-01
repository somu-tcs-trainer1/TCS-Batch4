const path = require('path');
const ExcelUtil = require('./ExcelUtil');
const CsvUtil = require('./CSVUtil');
const JsonUtil = require('./JSONUtil');

class DataFactory {
    /**
     * Generic method to read any supported test data file
     * @param {string} relativePath - Path from project root
     * @param {string} [sheetName] - Optional for Excel files
     */
    static getTestData(relativePath, sheetName = null) {
        const absolutePath = path.resolve(process.cwd(), relativePath);
        const extension = path.extname(absolutePath).toLowerCase();

        switch (extension) {
            case '.xlsx':
            case '.xls':
                return ExcelUtil.readData(absolutePath, sheetName);
            case '.csv':
                return CsvUtil.readData(absolutePath);
            case '.json':
                return JsonUtil.readData(absolutePath);
            default:
                throw new Error(`Unsupported file format: ${extension}`);
        }
    }
}
module.exports = DataFactory;
