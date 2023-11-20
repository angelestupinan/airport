namespace AirportAdministrator{
    class Program{
        static void Main(string[] args){
            List<string> flight_destination = new List<string>();
            List<string> flight_code = new List<string>();
            List<string> flight_number = new List<string>();
            List<string> flight_seats = new List<string>();
            int operation;

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
            public void getFlightInfo(string cd){
                int code_index = flight_code.IndexOf(cd.ToUpper());
                if(code_index != -1){
                    Console.Writeline(flight_destination[code_index]+" "+flight_code[code_index]+" "+flight_number[code_index]+" "+flight_seats[code_index]);
                }
                else{
                    Console.Writeline("Ingrese un codigo valido");
                }

            }
            public void removeFlight(string cd){
                int code_index = flight_code.IndexOf(cd.ToUpper());
                if(code_index != -1){
                    flight_destination.RemoveAt(code_index);
                    flight_code.RemoveAt(code_index);
                    flight_number.RemoveAt(code_index);
                    flight_seats.RemoveAt(code_index);
                }
                else{
                    Console.Writeline("Ingrese un codigo valido");
                }

            }

            Console.Writeline("Ingrese que operacion desea realizar, 1: Agregar vuelo 2:Consultar vuelo 3:eliminar vuelo");
            operation = int.Parse(Console.ReadLine());

            switch (operation){
                case 1:{
                    addFlight();
                    break;
                }
                case 2:{
                    string cdx = Console.ReadLine();
                    getFlightInfo(cdx);
                    break;
                }
                case 3:{
                   string cdx = Console.ReadLine();
                   removeFlight(cdx); 
                   break;
                }
            }

        }
    }
}