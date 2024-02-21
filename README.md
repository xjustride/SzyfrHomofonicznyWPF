# Homophonic Cipher Application

## Overview

This repository contains a WPF (Windows Presentation Foundation) application developed using .NET 6.0, implementing a homophonic cipher for text encryption and decryption. The homophonic cipher is an encryption technique that allows multiple ciphertext symbols to represent a single plaintext letter, making it more resistant to frequency analysis attacks than simple substitution ciphers. This application focuses on demonstrating the concept with an emphasis on the Polish language, including support for Polish-specific characters.

## Features

- **Text Encryption**: Encrypts input text using a predefined homophonic substitution scheme.
- **Text Decryption**: Decrypts the previously encrypted text back to its original form, assuming the correct homophonic codes are used.
- **Polish Language Support**: Includes mappings for the Polish alphabet, allowing for encryption and decryption of texts containing Polish diacritical marks.

## Requirements

- Windows operating system with .NET 6.0 SDK installed.
- Visual Studio 2019 or newer (recommended) for development purposes.

## Installation

1. **Clone the Repository**: Start by cloning this repository to your local machine using Git.

    ```
    git clone https://github.com/xjustride/SzyfrHomofonicznyWPF.git
    ```

2. **Open the Project**: Navigate to the cloned directory and open the `.sln` file in Visual Studio or your preferred .NET-capable IDE.

3. **Build the Application**: Compile the application using your IDE's build command or the .NET CLI with `dotnet build`.

4. **Run the Application**: Start the application from within your IDE, or use the `dotnet run` command in the directory containing the project file.

## Usage

To use the homophonic cipher application:

1. **Input Text**: Enter the text you wish to encrypt or decrypt in the input text box.
2. **Encrypt/Decrypt**: Click the "Encrypt" button to encrypt the input text, or the "Decrypt" button to decrypt the input text. Ensure the input for decryption matches the homophonic cipher format used during encryption.
3. **View Result**: The result of the encryption or decryption process will be displayed in the output text box.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

## Acknowledgments

- This application was developed as a proof of concept to demonstrate the implementation of a homophonic cipher with support for the Polish language.

