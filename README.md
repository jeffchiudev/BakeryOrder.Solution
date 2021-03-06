# _Pierre's Bakery Order Tracking_
### _When business is booming, orders need tracking, v1.0, 18.dec.2020_

<br>
<div align="center">
<img src="https://github.com/jeffchiudev.png" width="200px" height="auto" style="border-radius: 15px 50px;">
</div>
<p align="center">Authored by Jeff Chiu</p>
<p align="center">Updated on: 18.dec.2020</p>


## Description:

Pierre's bakery is a beloved institution in the Portland Metro area and as such there are many orders coming and going through the doors of the bakery that need to be detailed and tracked.  This app is designed to help Pierre, or any other interested large scale bakery that sells product to vendors to organize thieir orders. 

## Site link

[Click here](https://github.com/jeffchiudev/BakeryOrder.Solution) to visit the site.


## Setup/Installation Requirements:

### Software Requirements:

1. Internet browser of choice. Chrome is suggested.

2. A code editor like VSCode or Atom to view or edit the codebase.

3. Download C# and .NETframework [here](https://dotnet.microsoft.com/download/dotnet-core/2.2) if on windows and [here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) if on mac. To confirm install open a new Windows PowerShell window or git Bash terminal and run command `dotnet --version`. You should see a version number response similar to `2.2.203`.

### Open via Bash/GitBash:

1. Open terminal window and navigate to/create desired repository location.

2. Clone this repository onto your computer by using command: `git clone https://github.com/jeffchiudev/BakeryOrder.Solution`

3. Navigate to cloned repository and open in Visual Studio Code with `code .`.

4. In terminal, navigate to Bakery folder and run command `dotnet build` followed by `dotnet run` to see the working program.

## Testing Specifications:

1. Clone repository and navigate to the BakeryOrder.Tests directory.

2. Run commmands `dotnet restore` and `dotnet build` to download testing packages.

3. Run commands `dotnet test` to run testing suite. 

<details><summary>Click Here for Testing Specifications:</summary>
<p>

| Description | Input | Ouput |
| :---------- | :---- | :---- |
| Order |||
| should correctly instantiate instance of an Order | Order newOrder = new Order() | getType = Order |
| should correctly return details of an order | Order newOrder = new Order(string title, string description, int price, string date) | newOrder(title, description, price, date) |
| Order.GetAll() |||
| should correctly return an empty order list | List<Order> testList = Order.GetAll() | testList.Count = 0 |
| should correctly return an order list | Order testOrder = new Order(title,description,price,date) | List<Order> testList = new List<Order> {testOrder} |
| should correctly return a Order list with an ID number | Order testOrder = ne Order(etc..) | testOrder.Id = 1 |
| Order.Find(int searchId) |||
| should correctly return a order if searched for | Order testOrder = new Order(etc....) | Order.Find(1) = testOrder |
| Vendor |||
| should correctly instantiate Vendor class | Vendor newVendor = new Vendor() | getType = Vendor |
| should correctly retrieve a Vendor Id | Vendor testVendor = newVendor() | testVendor.Id = 1 |
| Vendor.GetAll() |||
| should correctly return a vendor object | List<Vendor> venList = new List<Vendor> { testVendor } | Vendor.GetAll = venList; |
| Vendor.Find(int searchId) |||
| should correctly return an Vendor by Id | Vendor testVendor = new VEndor(etc...) | Vendor.Find(1) = testVendor |
| Vendor.AddOrder(Order order) |||
| should correctly associate and order with a vendor | newVendor.AddOrder(testOrder) | List<testOrderList> = newVendor(testOrder) |

</p>
</details>

## Support and contact details:

If there are any issues, I can be contacted at jeffchiudev@gmail.com


## Technologies Used:

- C# 7.3

- ASP.NET Core MVC

- .NET Core 2.2

- REPL

- VS Code

- GitHub

This extension is licensed under the MIT license.

Copyright (c) 2020 *_Jeffrey W. Chiu_*