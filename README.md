<p align="center"><img src="assets/logo.png?raw=true" width="350" alt="Logo"></p>

# Extensions to the .NET System namespace

[![Build Status](https://dev.azure.com/dimenicsbe/Utilities/_apis/build/status/dimenics.system?branchName=master)](https://dev.azure.com/dimenicsbe/Utilities/_build/latest?definitionId=171&branchName=master) ![CodeQL](https://github.com/dimenics/system/workflows/CodeQL/badge.svg) ![Code coverage](https://img.shields.io/azure-devops/coverage/dimenicsbe/utilities/171/master)

## Introduction

This project is meant to extend the capabilities of the System namespace with extra utility functions.

## About this project

The most notable types in this assembly include:

- `Ensure`: a handy and lightweight validation class.
- `TryParse`: try parsing string to integers

## Getting Started

- You must have Visual Studio 2019 Community or higher.
- The dotnet cli is also highly recommended.

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
