package constructs.DealershipComponents;

import java.util.ArrayList;
import java.util.List;

public class Dealership {
	
	private String name;
	private int employees;
	private List<Department> departments;
	private List<Inventory> inventories;
	
	public Dealership(String dealershipName) {
		this.setName(dealershipName);
		this.departments = new ArrayList<Department>();
		this.inventories = new ArrayList<Inventory>();
	}
	
	
	// Methods
	
	public void addDepartment(Department department) {
		this.departments.add(department);
		this.updateEmployeeCount();
	}
	
	public void updateEmployeeCount() {
		int totalEmployees = 0;
		for (Department dept : this.departments) {
			totalEmployees += dept.getStaffCount();
		}
		this.employees = totalEmployees;
	}
	
	public void addInventory(Inventory inv) {
		inventories.add(inv);
	}
	
	public void printDealershipInfo() {
		System.out.println("Dealership \"" + this.getName() + "\":");
		System.out.println("Total Employees: " + this.getEmployeeCount());
		System.out.println("Departments:");
		for (Department dept : this.getDepartments()) {
			System.out.println("- " + dept.getName());
			System.out.println("-- Staff: " + dept.getStaffCount());
		}
		System.out.println("Inventories:");
		for (Inventory inv : this.inventories) {
			System.out.println("- " + inv.getName());
			if (inv.getInventorySize() == 0) {
				System.out.println("-- No Inventory");
			} else {
				System.out.println("-- " + inv.getInventorySize());
			}
		}
		System.out.println("\n");
	}
	
	
	// Getters & Setters

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getEmployeeCount() {
		return employees;
	}

	public List<Department> getDepartments() {
		return departments;
	}

	public List<Inventory> getInventories() {
		return inventories;
	}

}
