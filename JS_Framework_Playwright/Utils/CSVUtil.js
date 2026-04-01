const fs = require('fs');
const { parse } = require('csv-parse/sync');

class CsvUtil {
  static readData(filePath) {
    const fileContent = fs.readFileSync(filePath, 'utf-8');
    return parse(fileContent, {
      columns: true,           // Convert rows to objects using headers as keys
      skip_empty_lines: true,
      trim: true               // Clean whitespace from values
    });
  }
}
module.exports = CsvUtil;
