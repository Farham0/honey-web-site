using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Controllers
{
    public static class effects
    {
        public static  string welcome = @"
                                          {  
                                                 'scaleX': '2',
                                                 'scaleY': '2',
                                                 'x': '-40',
                                                 'y': '-40',
                                                 'rotation': '-4',
                                                 'alpha': '1',
                                                 'easingType': 'Cubic.easeOut',
                                                 'duration': '1'  
                                         }";


        public static string fromLeft = @"
                                          {  
                                                 'scaleX': '1',
                                                 'scaleY': '1',
                                                 'x': '-400',
                                                 'y': '-40',
                                                 'rotation': '0',
                                                 'alpha': '1',
                                                 'easingType': 'Cubic.easeOut',
                                                 'duration': '1'  
                                         }";


        public static string fromRight= @"
                                          {  
                                                 'scaleX': '1',
                                                 'scaleY': '1',
                                                 'x': '800',
                                                 'y': '-40',
                                                 'rotation': '0',
                                                 'alpha': '1',
                                                 'easingType': 'Cubic.easeOut',
                                                 'duration': '1'  
                                         }";


        public static string move = @"{'x': '-200','rotationY':'-180', 'duration': '2.5'}";



        public  static  string name= @"
                                        {'rotationY':'15', 'alpha': '0', 'duration': '1','scaleX': '0','scaleY': '0'}
                                        ";

        


    }
}