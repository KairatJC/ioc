# Problem Situation:
Class **Flower** not working without **Lamp**.   
Class **Lamp** not working without **Electricity**.   
   
If I change something in **Electricity**, I need to test **Lamp** and **Flower**.   
   
And if I have Dependency Hell when I have 100 dependencies, I need to test all.   
   
If something will be broken in Dependent Class, I also need to check all.   
   
In such a small program, this is not a problem. But we actually have a very huge codebase.   