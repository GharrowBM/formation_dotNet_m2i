const readline = require('readline')
const readLineInterface = readline.createInterface({
    input:process.stdin,
    output: process.stdout
})


const notrePropreQuestion = async (question) => {
    const result = await readLineInterface[Symbol.asyncIterator]().next()
    return await result.value
}

exports.notrePropreQuestion = notrePropreQuestion