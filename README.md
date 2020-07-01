# Dime.System

![Build Status](https://dev.azure.com/dimenicsbe/Utilities/_apis/build/status/dimenics.dime-system?branchName=master) ![Code coverage](https://img.shields.io/azure-devops/coverage/dimenicsbe/utilities/148/master)

## Introduction

Extensions to the System namespace.

## Getting Started

- You must have Visual Studio 2019 Community or higher.
- The dotnet cli is also highly recommended.

## About this project

The most notable types in this assembly include:

- `Ensure`: a handy and lightweight validation class.

## Build and Test

- Run dotnet restore
- Run dotnet build
- Run dotnet test

## Installation

Use the package manager NuGet to install Dime.System:

`dotnet add package Dime.System`

## Usage

``` csharp
using System;

public void MyMethod(MyClass myClassParameter)
{
    Ensure.Argument.NotNull(myClassParameter, nameof(myClassParameter), "Parameter cannot be null");
}
```

## Contributing

![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)

Pull requests are welcome. Please check out the contribution and code of conduct guidelines.

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)