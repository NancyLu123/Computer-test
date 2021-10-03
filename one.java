//一、物件導向-繼承/介面 
public class HelloWorld{

     public static void main(String []args){
        Car whiteCar =  new Car();
        whiteCar.setColor("white");
        whiteCar.getColor();
     }
}
interface Transportation{
    public abstract void startEngine();
}

class Car implements Transportation{
    private String color;
    private String wheelNum;
    public void startEngine(){
        System.out.print("car is work");
    }
    public String getcolor(){
        return this.color;
    }
    public void setColor(String color){
        this.color = color;
    }
}

class Motocycle implements Transportation{
    private String color;
    private String wheelNum;
    public void startEngine(){
        System.out.print("Motocycle is work");
    }
    public String getcolor(){
        return this.color;
    }
    public void setColor(String color){
        this.color = color;
        
    }
}