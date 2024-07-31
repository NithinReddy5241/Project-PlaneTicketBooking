using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PlaneTicketBooking
{
    public interface IFlightRules
    {
        bool IsAvailable();
        bool IsBooked();
        bool IsCancelled();
    }
    abstract class Fdetails
    {
      public abstract void SetDetials();
     
    }    
    class Flights :Fdetails
    {
        public string Name {  set; get; }
        public int Age {  set; get; }public string PickupLoc { set; get; }public string DropLoc { set; get; }
        
        public  virtual bool IsAvailable()
        {
            return true;
        }
        public virtual  bool IsBooked()
        {
           // Console.WriteLine("Booked Sucessfully!");
            return true;
        }
        public virtual bool IsCancelled()
        {
            return true;
        }
        public override void SetDetials()
        {
            Console.WriteLine("Enter Name, Age: ");
            this.Name = Console.ReadLine();
            this.Age = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("Enter Pickup Location and Drop Location: "); 
            this.PickupLoc = Console.ReadLine();
            this.DropLoc = Console.ReadLine();
        }
        public override string ToString()
        {
            return "Name is " + this.Name + "\nAge is " + this.Age+ "\nPickup Location "+this.PickupLoc+ "\nDrop Location "+this.DropLoc;
        }
    }
    class B777 : Flights
    {
        public string FName { set; get; }public bool Flag=false;public bool Flag1 = false; public string BId;
        public override void SetDetials()
        {
            Random R = new Random(); BId += "777BB" + R.Next(100, 1000);
            base.SetDetials();
            
        }
        public override string ToString()
        {
            this.FName = "Boeing 777";
            
            return "Flight Details\n"+this.FName+base.ToString()+"\nBooking Id: " + this.BId;
        }

        public override bool IsAvailable()
        {
            if (!Flag)
            {
                Console.WriteLine("Boeing 777 flight is Available.");
                Flag = true;return true;
            }
            else
            {
                Console.WriteLine("Boeing 777 flight is not available!");
                Flag = false; return false;
            }
        }
        public override bool IsBooked()
        {
            if (Flag)
            {
                //Console.WriteLine("Flight B777 is Booked Sucessfully!");
                Flag1 = true;
                Flag = false; return true;
            }
            else
            {
                Console.WriteLine("Flight B777 is Already Booked!");
                Flag1 = true; return false;
            }
        }
        public override bool IsCancelled()
        {
            if (Flag1)
            {
                this.Name = null;ToString();
                 Console.WriteLine("Flight Cancelled Sucefully!");Flag1 = false;
                return true;
            }
            else
            {
                Console.WriteLine("No Details Found to Cancel.");
                Flag1 = true; return false;
            }
        }
    }
    class B757 : Flights
    {
        public string FName { set; get; }public bool Flag=false; public bool Flag1 = false; public string BId;
        public override void SetDetials()
        {
            Random R = new Random();
            base.SetDetials(); BId += "757BB" + R.Next(100, 1000);
        }
        public override string ToString()
        {
            this.FName = "Boeing 757"; 
            return " Flight Details:\n"+this.FName+"\n"+base.ToString()+"\nBooking Id: "+this.BId;
        }
        public override  bool IsAvailable()
        {
            if (!Flag)
            {
                Console.WriteLine("Boeing 757 flight is available");
                Flag = true;
                return true;
            }
            else
            {
                Console.WriteLine("Boeing 757 flight is not available!");return false;
            }
        }
        public override bool IsBooked()
        {
            if (Flag)
            {
                Flag = false;
                Console.WriteLine("Flight B757 is Booked Sucessfully!");return true;
            }
            else
            {
                Console.WriteLine("Flight B757 is Already Booked!");return false;
            }
        }
        public override bool IsCancelled()
        {
            if (Flag1)
            {
                 this.Name = null;ToString();
                Console.WriteLine("Flight Cancelled Sucefully!"); Flag1 = false;
                return true;
            }
            else
            {
                Console.WriteLine("No Details Found to Cancel.");
                Flag1 = true; return false;
            }
        }
    }
    class B737 : Flights
    {
        public string FName { set; get; }public bool Flag=false; public bool Flag1 = false;public string BId;
        public override void SetDetials()
        {
            Random R = new Random(); BId += "737BB" + R.Next(100, 1000);
            base.SetDetials();
        }
        public override string ToString()
        {
            this.FName = "Boeing 737";
            return "Flight Details:\n"+this.FName+"\n"+base.ToString()+ "\nBooking Id: " + this.BId;
        }
        public override bool IsAvailable()
        {
            if (!Flag)
            {
                Console.WriteLine("Boeing 737 flight is available");
                Flag = true;return true;
            }
            else
            {
                Console.WriteLine("Boeing 737 flight is not available!");return false;
            }
        }
        public override bool IsBooked()
        {
            if (Flag)
            {
                Flag = false;
                Console.WriteLine("Flight B737 is Booked Sucessfully!"); return true;
            }
            else
            {
                Console.WriteLine("Flight B737 is Already Booked!"); return false;
            }
        }
        public override bool IsCancelled()
        {
            if (Flag1)
            {
                this.Name = null;ToString(); 
                Console.WriteLine("Flight Cancelled Sucefully!"); Flag1 = false;
                return true;
            }
            else
            {
                Console.WriteLine("No Details Found to Cancel.");
                Flag1 = true; return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        { string Choice;
            bool Flag = false;
            B777 B1 = new B777();
            B757 B2 = new B757(); 
            B737 B3 = new B737();           
            do
            {
                Console.WriteLine("Enter Option to To Perform Operation: \n1 Check Availabilty of Flights." +
                    "\n2 Book the Flight \n3 Cancel the flight.\n4 Display the Booking information.");
                int Opt = Convert.ToInt32(Console.ReadLine());
                switch (Opt)
                {
                    case 1:
                        {
                            B1.IsAvailable();
                            B2.IsAvailable(); 
                            B3.IsAvailable(); 
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("************************************************************************************");
                            Console.WriteLine("Note: First Check the avalability if not you cannot book Flights!!! If Checked Please Ignore!");
                            Console.WriteLine("************************************************************************************");
                            Console.WriteLine(" Enter option to book the Required Flight\n" +
                            "1 Boeing 777\n2 Boeing 757 \n3 Boeing 737 ");
                            int op = Convert.ToInt32(Console.ReadLine());
                            switch (op)
                            {
                                case 1:
                                    {
                                        if (B1.IsBooked())
                                        {
                                            B1.SetDetials(); Console.WriteLine("************************************************************************************");
                                            Console.WriteLine("Booking Details:\n"+B1); Console.WriteLine("************************************************************************************");
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        if (B2.IsBooked())
                                        {
                                            B2.SetDetials(); Console.WriteLine("************************************************************************************");
                                            Console.WriteLine("Booking Details:\n" + B2); Console.WriteLine("************************************************************************************");
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        if (B3.IsBooked())
                                        {
                                            B3.SetDetials(); Console.WriteLine("************************************************************************************");
                                            Console.WriteLine("Booking Details:\n" + B3); Console.WriteLine("************************************************************************************");
                                        }
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Enter a Valid Option!"); break;
                                    }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter option to Cancel the Required Flight\n" +
                            "1 Boeing 777\n2 Boeing 757 \n3 Boeing 737 ");
                            int op = Convert.ToInt32(Console.ReadLine());
                            switch (op)
                            {
                                case 1:
                                    {                                        
                                        B1.IsCancelled();
                                        break;
                                    }
                                case 2:
                                    {
                                        B2.IsCancelled();
                                        break;
                                    }
                                case 3:
                                    {                                        
                                        B3.IsCancelled();                                      
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Enter a Valid Option!"); break;
                                    }
                            }
                            break;

                        }
                    case 4:
                        {
                            if (B1.Name != null) { Console.WriteLine("************************************************************************************"); Console.WriteLine(B1);
                                Console.WriteLine("************************************************************************************"); Flag = true; }
                            if (B2.Name != null) { Console.WriteLine("************************************************************************************"); Console.WriteLine(B2);
                                Console.WriteLine("************************************************************************************"); Flag = true; }
                            if (B3.Name != null) { Console.WriteLine("************************************************************************************"); Console.WriteLine(B3);
                                Console.WriteLine("************************************************************************************"); Flag = true; }
                            if (!Flag){ Console.WriteLine("************************************************************************************"); Console.WriteLine("No Flight is booked !");
                                Console.WriteLine("************************************************************************************"); }
                            break;
                        }
                }
                Console.WriteLine("Enter N/n to stop ");
                Choice = Console.ReadLine();
            } while (!(Choice.Equals("N") || Choice.Equals("n")));
           // Console.Read();
        }
    }
}
