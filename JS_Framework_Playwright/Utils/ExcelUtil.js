const XLSX = require('xlsx');
const fs = require('fs');
const path = require('path');


// class ExcelUtil {
//   static readData(filePath, sheetName = null) {
//     const workbook = XLSX.readFile(filePath);
//     // Use first sheet if sheetName is not provided
//     const selectedSheet = sheetName || workbook.SheetNames[0];
//     const worksheet = workbook.Sheets[selectedSheet];
//     return XLSX.utils.sheet_to_json(worksheet);
//   }
// }
// module.exports = ExcelUtil;

class ExcelUtil {
    /**
     * Reads an Excel file and returns data as an Array of Objects.
     * @param {string} filePath - Absolute path to the .xlsx file.
     * @param {string} [sheetName] - Optional: Name of the specific tab to read.
     * @returns {Array<Object>} - The parsed data.
     */
    static readData(filePath, sheetName = null) {
        // 1. Physical File Validation
        if (!fs.existsSync(filePath)) {
            throw new Error(`Excel file not found at: ${filePath}`);
        }

        try {
            // 2. Load the Workbook
            const workbook = XLSX.readFile(filePath);

            // 3. Determine which sheet to read
            // If no sheetName is provided, default to the very first tab [0]
            const targetSheetName = sheetName || workbook.SheetNames[0];
            
            const worksheet = workbook.Sheets[targetSheetName];

            // 4. Validate if the sheet exists in the workbook
            if (!worksheet) {
                throw new Error(`Sheet "${targetSheetName}" not found in ${path.basename(filePath)}`);
            }

            /**
             * 5. Convert to JSON
             * 'defval: null' ensures that empty cells in Excel still show up as 
             * { key: null } instead of being missing from the object entirely.
             */
            const jsonData = XLSX.utils.sheet_to_json(worksheet, {
                defval: null, 
                raw: true     // Keeps dates/numbers in their raw format for processing
            });

            return jsonData;
        } catch (error) {
            throw new Error(`Failed to parse Excel file: ${error.message}`);
        }
    }
}
module.exports = ExcelUtil;

    // async readExcelFile(fileName) {
    //     const xlFilePath = path.join(__dirname, fileName);
    //     const workbook = XLSX.readFile(xlFilePath);
    //     const SheetName = workbook.SheetNames[0];
    //     const sheet = workbook.Sheets[SheetName];

    //     for (let index = 2; index < 5; index++) {
    //         const name = sheet[`A${index}`].v;
    //         const email = sheet[`B${index}`].v;
    //         const phone = String(sheet[`C${index}`].v);
    //         console.log("Name from excel: ", name);
    //         console.log("Email from excel: ", email);
    //         console.log("Phone from excel: ", phone);
    //     }
    // }
