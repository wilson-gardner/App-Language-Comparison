package constructs.DealershipComponents;

import java.util.ArrayList;
import java.util.List;
import constructs.VehicleComponents.*;

public class Inventory {
	private String name;
	private List<Vehicle> vehicles;
	
	public Inventory(String invName) {
		this.setName(invName);
		this.vehicles = new ArrayList<Vehicle>();
	}
	
	
	// Methods
	public void addVehicle(Vehicle vehicle) {
		vehicles.add(vehicle);
	}
	
	public int getInventorySize() {
		return this.vehicles.size();
	}
	
	
	// Getters & Setters
	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}
	
	public List<Vehicle> getInventory() {
		return this.vehicles;
	}
}
