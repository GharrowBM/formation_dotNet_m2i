const readline = require('readline')



const notrePropreQuestion = async (question) => {
    console.log(question)
    const readLineInterface = readline.createInterface({
        input:process.stdin,
        output: process.stdout
    })
    const result = await (await readLineInterface[Symbol.asyncIterator]().next()).value
    readLineInterface.close()
    return result
}

exports.notrePropreQuestion = notrePropreQuestion