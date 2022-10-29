class Circle
{
    
    private double radius;
    private double PI = 3.14;
    
    public Circle(double a)
    {
        radius = a;
    }
 
        public double GetDiameter()
        {
            
                return radius * 2;
            
        }


        public double GetArea()
        {
            
            
                return PI * radius * radius;

        }
        public double GetCircumference()
        {
            
                return 2 * PI * radius;

        }
        
        public double GetRadius()
        {
         
            
                return radius;
        
            
        }
}
    
