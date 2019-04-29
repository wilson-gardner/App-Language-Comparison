package app;

import constructs.DealershipComponents.*;
import constructs.VehicleComponents.*;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		// Create a Dealership
		Dealership myDealer = new Dealership("Wilson's Cars");
		
		/*
		 * The following mimicks user input
		 */
		
		// Create departments
		Department dept = new Department("Sales", 5);
		myDealer.addDepartment(dept);
		Department dept2 = new Department("Service", 10);
		myDealer.addDepartment(dept2);
		
		// Create inventories
		Inventory newInv = new Inventory("New Car");
		myDealer.addInventory(newInv);
		Inventory usedInv = new Inventory("Used Car");
		myDealer.addInventory(usedInv);
		
		// Print dealership info (results below):		
		myDealer.printDealershipInfo();
		/*
		 	Dealership "Wilson's Cars":
			Total Employees: 15
			Departments:
			- Sales
			-- Staff: 5
			- Service
			-- Staff: 10
			Inventories:
			- New Car
			-- No Inventory
			- Used Car
			-- No Inventory
		*/
	}

}
