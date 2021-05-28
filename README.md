# RSASoftOnlineTest
 
This is a test solution to ask user for a small online test.

### Testing Instructions (Instructions not in chronological order)
1. Get all Test Cases to Pass.
2. Create Method to Validate the format of PONumber in form of `XXX-0000000000` (3 Chars - 10 integers)
	* No Interger allowed in Char field. 
	* No Char allowed in Interger field
	* Create a test Case for the above new method
	* `Use Example Basic Math`
3. Create Method to Validate the format of CustomerOrderNumber in form of `XXX-XXX-00000` (3 Chars - 3 Chars - 5 integers)
	* No Interger allowed in Char field. 
	* No Char allowed in Interger field
	* Create a test Case for the above new method
	* `Use Example Basic Math`
4. Fix Order class to have OrderHeaderDetails and OrderLineDetails as properties with a Contructor
5. Create a list of 3 Orders
	* First Order contains 1 Line
	* Second Order contains 2 Lines
	* Third Order contains 3 Lines
6. Create a method in Header to Validate All Lines
	* Validate the StockCode is not Empty or Null
	* Validate the Quantity > 0
	* Validate the StockDescription is not Empty or Null
	* Validate Price > 0.00 and < 15.54
	* Validate Total is = Quantity * CustomerPrice
7. Create a method in Order to Validate All Headers
	* Header Contains lines
	* Validate Header Number of Lines = Lines Count
	* This is where point 2 and 3 will be added.
	* Validate Customer Contains at least 5 Chars
	* Validate Header Total = Lines Totals
