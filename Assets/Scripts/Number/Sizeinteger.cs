using UnityEngine;

public class Sizeinteger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SignedIntgeger
        sbyte ISbyte = 127; //8비트 부호가 잇는 정수형 변수 선언 및 초기화
        short Iint16 = 12767; //16비트 부호가 있는 정수형 변수 선언 및 초기화
        int IInt32 = 2147483647; //32비트 부호가 잇는 정수형 변수 선언 및 초기화
        long Iint64 = 9223372000000; //64비트 부호가 있는 정수형 변수 선언 및 초기화

        Debug.Log(ISbyte);
        Debug.Log(Iint16);
        Debug.Log(IInt32);
        Debug.Log(Iint64);
    
        //
        //UnsignedIngeger
        byte IByte = 255; //8비트 부호가 있는 정수형 선언 및 초기화
        ushort IUint16 = 65535; //16비트 부호가 있는 정수형 변수 선언 및 초기화
        uint IUint32 = 4294000;
        ulong IUint64 = 123400000;

        Debug.Log("byte: " + IByte);
        Debug.Log("ushort: " + IUint16);
        Debug.Log("uint: " + IUint32);
        Debug.Log("ulong: " + IUint64);
    }
    /*
    1 Bit 0,1
    1 Byte = 8 Bit 0-255
    0000 0000 0
    0000 0001 1
    0000 0010 2
    0000 0011 3
    0000 0100 4
    0000 0101 5
    0000 0111 6 
    0000 1000 7
    0000 1001 8
    
    8Bit
    (=,-,0)
    sbyte : -128~127
    
    (+,0)
    byte : 0 - 255
    */

    /*
    signedIngeger (+,-)부호가 있는 정수형 데이터 형식(타입)
      

    UnsignedIngeger (+,-)부호가 없는 정수형 데이터 형식(타입)
     */
}
