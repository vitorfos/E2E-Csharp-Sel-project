# Selenium Core Demo

This project is a demonstration of using Selenium with C# for automated testing. It includes a basic structure for managing WebDriver instances, defining page objects, and executing tests.

## Project Structure

- **Drivers**: Contains the `WebDriverManager` class responsible for initializing and managing the WebDriver instance.
- **Tests**: Contains the `SampleTest` class with test methods that utilize Selenium to perform automated tests.
- **Pages**: Contains the `HomePage` class representing the home page of the application, including methods for navigation and verification.
- **Utilities**: Contains the `HelperMethods` class with utility methods for use across tests.

## Setup Instructions

1. **Prerequisites**: Ensure you have .NET SDK installed on your machine.
2. **Clone the Repository**: Clone this repository to your local machine.
3. **Install Dependencies**: Navigate to the project directory and run the following command to restore the necessary packages:
   ```
   dotnet restore
   ```
4. **Run Tests**: To execute the tests, use the following command:
   ```
   dotnet test
   ```

## Usage

- Modify the `WebDriverManager` class to configure the WebDriver as needed.
- Add additional test methods in the `SampleTest` class to cover more scenarios.
- Utilize the `HelperMethods` for common actions like waiting for elements or taking screenshots.

## Contributing

Feel free to submit issues or pull requests for improvements or additional features.