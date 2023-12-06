Console.Title = "check check";

for(int i = 1; i <= 6; i++){
    Console.Write( i + "    ");
    if(i == 6){
        Console.Write("\n");
    } else{
        continue;
    }
        for(int j = 6; j <= 8; j += 2){
            Console.Write( j + "    ");
        if(j == 8){
            j += 2; Console.Write(j + "   ");
            for(j = 12; j <= 16; j += 2){
                Console.Write(j + "   ");
            } Console.Write("\n");
        } else {
            continue;
        }
            for(int k = 16; k <= 31; k += 3){
                Console.Write( k + "   ");
                if( k == 31){
                    Console.Write("\n");
                } else{
                    continue;
                }
            }
                for(int g = 31; g <= 51; g += 4){
                Console.Write( g + "   ");
                if( g == 51){
                    Console.Write("\n");
                } else{
                    continue;
                } 
            }
                for(int s = 51; s <= 76; s += 5){
                Console.Write( s + "   ");
                if( s == 76){
                    Console.Write("\n");
                } else{
                    continue;
                } 
            }
                for(int a = 76; a <= 94; a += 6){
                    Console.Write( a + "   ");
                if(a == 88){
                    a += 6; Console.Write(a + "   ");
                for(a = 100; a <= 106; a += 6){
                    Console.Write(a + "  ");
                } Console.Write("\n");
                } else {
                    continue;
                }
    }
}

} Console.ReadKey();