namespace Airport
{
    internal class FlightInfo{
    public string destination;
    public string code;
    public string hour;
    private int airplane_number;
    private int seats;

    public void setDestination(string dest){
        destination = dest;
    }
    public void setCode(string cod){
        code = cod;
    }
    public void setHour(string hou){
        hour = hou;
    }
    public void setAirpNumb(int numb){
        airplane_number = numb;
    }
    public void setSeats(int seat){
        seats = seat;
    }

    public string getDestination(){
        return destination;
    }
    public string getCode(){
        return code;
    }
    public string getHour(){
        return hour;
    }
    public int getAirpNumb(){
        return airplane_number;
    }
    public int getSeats(){
        return seats;
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            int flight_number;
            string flight_details;

            FlightInfo flight1 = new FlightInfo();
            FlightInfo flight2 = new FlightInfo();
            FlightInfo flight3 = new FlightInfo();

            flight1.setDestination("Brazil");
            flight1.setCode("br23A");
            flight1.setHour("10:30");
            flight1.setAirpNumb(20);
            flight1.setSeats(250);

            flight2.setDestination("Panama");
            flight2.setCode("pan54b");
            flight2.setHour("18:15");
            flight2.setAirpNumb(58);
            flight2.setSeats(200);

            flight3.setDestination("Spain");
            flight3.setCode("sp27d");
            flight3.setHour("20:00");
            flight3.setAirpNumb(8);
            flight3.setSeats(300);

            Console.Writeline("ingrese el numero del vuelo que desea conocer su informacion");
            fligh_number = int.Parse(Console.ReadLine());

            if(flight_number == 1){
                flight_details = flight1.getDestination()+" "+flight1.getCode()+" "+flight1.getHour()+" "+flight1.getAirpNumb()+" "+flight1.getSeats();
                Console.Writeline(flight_details);
            }
            else if(flight_number == 2){
                flight_details = flight2.getDestination()+" "+flight2.getCode()+" "+flight2.getHour()+" "+flight2.getAirpNumb()+" "+flight2.getSeats();
                Console.Writeline(flight_details);
            }
            else if(flight_number == 3){
                flight_details = flight.getDestination()+" "+flight.getCode()+" "+flight.getHour()+" "+flight.getAirpNumb()+" "+flight.getSeats();
                Console.Writeline(flight_details);
            }
            else{
                Console.Writeline("el numero de vuelo ingresado no se corresponde a ningun vuelo");
            }
        }
    }
}