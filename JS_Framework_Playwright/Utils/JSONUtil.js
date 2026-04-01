const fs = require('fs');

class JsonUtil {
  static readData(filePath) {
    const rawData = fs.readFileSync(filePath, 'utf-8');
    return JSON.parse(rawData);
  }
}
module.exports = JsonUtil;
