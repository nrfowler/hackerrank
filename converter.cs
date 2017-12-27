
using System;
using System.Collections;


class Converter{

	static void Main(){
    String hex = "49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206d757368726f6f6d";
	
    ArrayList hexList = new ArrayList();
    for(int i = 0; i < hex.Length ; i+=2){
        hexList.Add((byte)(hex[i]*16+hex[i+1]));
		
	}
	byte[] hexArray = hexList.ToArray(typeof(byte)) as byte[];
	
	Console.WriteLine("Expected Binary: 100100");
	Console.WriteLine("Actual Binary: {0}",hexArray[0]);
	
	//Console.WriteLine("Actual Binary: {0}",hexArray.ToArray(typeof()
	Console.WriteLine("Expected: SSdtIGtpbGxpbmcgeW91ciBicmFpbiBsaWtlIGEgcG9pc29ub3VzIG11c2hyb29t");
    Console.WriteLine("Actual: {0}",Convert.ToBase64String(hexArray));
    }
}