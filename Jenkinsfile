pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        sh 'sh \'dotnet build\''
      }
    }

    stage('Test') {
      steps {
        sh 'sh \'dotnet test\''
      }
    }

  }
}