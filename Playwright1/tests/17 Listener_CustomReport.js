class MyReporter {
  onBegin(config, suite) {
    console.log(`Starting the test suite with ${suite.allTests().length} tests`);
  }

  onTestBegin(test) {
    console.log(`Starting test ${test.title}`);
  }

  onStepBegin(test, result, step){
    console.log(`Starting step ${step.title} from ${test.title}`);
  }

    onStepEnd(test, result, step){
    console.log(`Ending step ${step.title} from ${test.title} and the result is ${result.status}`);
  }

  onTestEnd(test, result) {
    console.log(`Finished Test ${test.title}: Status: ${result.status}`);
  }

  onEnd(result) {
    console.log(`Finished the test run. The final status: ${result.status}`);
  }
}

export default MyReporter;