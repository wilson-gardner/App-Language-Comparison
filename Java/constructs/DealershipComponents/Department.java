package constructs.DealershipComponents;

public class Department {
	
	private String name;
	private int staff;
	
	
	public Department(String deptName, int staffCount) {
		this.name = deptName;
		this.staff = staffCount;
	}


	public String getName() {
		return name;
	}


	public void setName(String name) {
		this.name = name;
	}

	
	public int getStaffCount() {
		return staff;
	}


	public void setStaffCount(int staff) {
		this.staff = staff;
	}

}
