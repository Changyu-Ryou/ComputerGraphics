#include <CapacitiveSensor.h> //정전식 센서 라이브러리 추가
#include <Servo.h> //servo 라이브러리 추가
#include <SoftwareSerial.h>

CapacitiveSensor cs_8_10=CapacitiveSensor(8,10);
SoftwareSerial hc06(2,3); //Tx, Rx
Servo servo;

const unsigned int POTENTIAL=A0;

int sensor_value=0;

int btnPin=5;
int btnPin2=6;
int ledPin=13;
int ledPin2=8;
int buttonstate=0;
char data;

int servomove(){
      servo.write(100);
      delay(200);
      servo.write(0);
      delay(400);
      return 1;
}
void setup() {
  Serial.begin(9600);
  hc06.begin(9600);
  servo.attach(11);   //servo 핀 설정
  Serial.println("Enter AT commands:");

  cs_8_10.set_CS_AutocaL_Millis(0xFFFFFFFF);
  
  pinMode(ledPin, OUTPUT);
  pinMode(ledPin2, OUTPUT);
  pinMode(btnPin, INPUT);
  pinMode(btnPin2, INPUT);
  
  digitalWrite(btnPin,HIGH);
  digitalWrite(btnPin2,HIGH);
  servo.write(0);
}

void loop() {
  sensor_value=analogRead(POTENTIAL);
  
  long total1 = cs_8_10.capacitiveSensor(30);
   if(total1>80){
    hc06.println("input Money");
    Serial.println("input Money");
    delay(2000);
   }
  if(hc06.available()){
    //Serial.write(hc06.read()); //블루투스 내용을 시리얼에 쓰기
    char value = hc06.read();//-'0';
    //Serial.write(value);
    if(value==1){
      Serial.println("msg = "+value);
      digitalWrite(ledPin2,LOW);
    }
    else if (value==10){
      Serial.println("서보모터 동작");
      while(1){
      if(servomove()==1){
        break;
        }
      }
     
      digitalWrite(ledPin2,HIGH);
    }else
    {
      Serial.println(value);
    }
  }

  if(Serial.available()){
    hc06.write(Serial.read()); //시리얼 모니터 내용을 블루투스에 쓰기
    Serial.println(Serial.read());
  }

  //delay(500);
  
   data=Serial.read();
    if(data=='A'){
        digitalWrite(ledPin2,HIGH);
        delay(100);
        digitalWrite(ledPin2,LOW);
        delay(100);
    }
  
   buttonstate=digitalRead(btnPin);
   
   if(digitalRead(btnPin)==LOW){
      //Serial.print(2);
      char value1 = '1';
      //hc06.write(value1);
      hc06.println("on");
      Serial.write(Serial.read());
      //hc06.write(Serial.read());
      //hc06.println(Serial.read());
      Serial.flush();

      //임시 테스트
      while(1){
        Serial.write("test구간 진입");
      if(servomove()==1){
        
        break;
        }
      }

   }
    if(digitalRead(btnPin2)==LOW){
      //Serial.print(3);
      //Serial.write(2);
      Serial.flush();
      //hc06.write("3");
      hc06.println("off");
      //digitalWrite(ledPin2,LOW);
      //digitalWrite(ledPin,HIGH);
      delay(30);  
   }

}
