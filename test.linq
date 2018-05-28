<Query Kind="Program" />

void Main()
{
	var fund = 600000;
	double leftover = 0;
	for(int i = 0, j=0; i<1095; i++){
	    var returnInterest = fund * returnValue(j) * j / 365;
		
		// this shouldn't keep increasing
		if(returnInterest > 10000){
			fund += 10000;
			leftover += (returnInterest - 10000);
			j = 0;
		}
		j++;
	}
	
	(fund + leftover).Dump();
	// Choose Return Value
	((600000 * returnValue(365) * 730 / 365) + 600000).Dump();
	
	(((600000 * returnValue(365) * 730 / 365) + 600000) - (fund + leftover)).Dump();
}

// Define other methods and classes here
private double returnValue(int days){
	switch(days){
		case int n when (n <= 6):
			return 0.035;
		case int n when (n <= 13):
			return 0.037;
		case int n when (n <= 20):
			return 0.039;
		case int n when (n <= 30):
			return 0.042;
		case int n when (n <= 60):
			return 0.044;
		case int n when (n <= 90):
			return 0.045;
		case int n when (n <= 180):
			return 0.046;
		case int n when (n <= 364):
			return 0.0465;
		default:
			return 0.047;
	}
}