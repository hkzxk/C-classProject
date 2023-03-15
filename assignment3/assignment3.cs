using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Xml;



interface Shape {
    public double width { get;set; }
    public double height { get;set; }
    public double are { get;set; }
    //public bool isLegal();
    


}

public class Rectangle : Shape
{
    public double width_r;
    public double height_r;
    public double area_r;
    

    public double width { get { return width_r; } set { width = value; } }
    public double height { get { return height_r; } set { height = value; } }
    public double are { get { cal_area(); return area_r; } set { are = value; } }

    public Rectangle(double w, double h)
    {
        width_r = w;
        height_r = h;
        //this.height = height;
        if (!isLegal()) throw new SystemException("illegal rectangle!");
        cal_area();
        Console.WriteLine("this is a rectangle , width is {0} , height is {1}, area is {2}", width, height, are);
    }
    bool isLegal()
    {
        return height_r > 0 && width_r > 0; 
    }
    void cal_area()
    {
        if(isLegal())area_r = height * width;
        else { throw new SystemException("illegal shape, can not calculate area!"); }
    }


}

public class Triangle : Shape
{
    public double side_1, side_2, side_3,area;//the bottom line is the side_1 defaultly

    public double width { get { return side_1; } set { width = value; } }
    public double height { get { return side_2; } set { height = value; } }
    public double are{ get { cal_area(); return area; } set { are = value; } }

    public Triangle(double side_1, double side_2, double side_3)
    {
        
        this.side_1 = side_1;
        this.side_2 = side_2;
        this.side_3 = side_3;
        //if (!isLegal()) throw new SystemException("illegal triangle!");
        //area = cal_area(side_1, side_2, side_3);
        Console.WriteLine("this is a triangle , width is {0},  height is {1}, area is {2}",width,height,are);


    }

    
    void cal_area()
    {
        double p = 0.5 * (this.side_3 + this.side_1 + this.side_2);

        area = Math.Sqrt(p * (p - this.side_1) * (p - this.side_2) * (p - this.side_3));
    }
    bool isLegal()
    {
        return this.side_1 + this.side_2 > this.side_3 && this.side_3 + this.side_2 > this.side_1 
            && this.side_1 + this.side_3 > this.side_2;
    }


    
}

public class Circle : Shape
{
    public double radius,area;
    public double width { get { return radius*2; } set { width = value; } }
    public double height { get { return radius*2; } set { height = value; } }
    public double are { get { cal_area(); return area; } set { are = area; } }
    public Circle(double radius)
    {
        this.radius = radius;
        if (!isLegal()) throw new SystemException("illegal circle!"); 
        cal_area(); 
        Console.WriteLine("this is a circle, radius is {0} , area is {1}", radius, area);

    }
    
    bool isLegal()
    {
        return radius > 0;
    }
    void cal_area()
    {
        this.area = Math.PI * radius * radius;
    }
   
}


//工厂类
enum shape_type{ TRIANGLE, CIRCLE, RECTANGLE};
class ShapeFactory
{
    
         void createShape(shape_type s_type,double height , double width)
    {
        switch (s_type)
        {
            case shape_type.TRIANGLE:
                Shape tri = new Triangle(height, height, width);
                
                break;
            case shape_type.CIRCLE:
                Shape cir = new Circle(width / 2);
                
                break;
            case shape_type.RECTANGLE:
                Shape rec = new Rectangle( width,height);
                
                break;

        }
    }
    static void Main(string[] args)
    {
        ShapeFactory factory = new ShapeFactory();
        factory.createShape(shape_type.CIRCLE, 1, 1);
        Random random = new Random();
        int n = 100;
        for(int i = 0;i < n; i++)
        {
            int inx = random.Next(0, 3);
            shape_type[]shapes = Enum.GetValues(typeof(shape_type)) as shape_type[];
            factory.createShape(shapes[inx],random.NextDouble()*100 + 2,random.NextDouble()*100 + 2);
        }

    }
}