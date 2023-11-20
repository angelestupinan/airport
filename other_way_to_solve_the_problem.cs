namespace AirportAdministrator{
    class Program{
        static void Main(string[] args){
            List<string> flight_destination = new List<string>();
            List<string> flight_code = new List<string>();
            List<string> flight_number = new List<string>();
            List<string> flight_seats = new List<string>();

            public void addFlight(string a, string b, string c, string d){
                if(a!=" "&&b!=" "&&c!=" "&&d!=" "){
                  flight_destination.Add(a.ToUpper());
                  flight_code.Add(b.ToUpper());
                  flight_number.Add(c.ToUpper());
                  flight_seats.Add(d.ToUpper());  
                }
                else{
                    Console.Writeline("ninguno de los valores puede estar vacio"); 
                }
            }
        }
    }
}