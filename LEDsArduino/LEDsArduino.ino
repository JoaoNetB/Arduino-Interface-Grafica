
 
const int led1 = 4;
const int led2 = 3;
const int led3 = 2;

void setup() {
  Serial.begin(9600);
  pinMode(led1, OUTPUT);
  pinMode(led2, OUTPUT);
  pinMode(led3, OUTPUT);
  digitalWrite(led1, LOW);
  digitalWrite(led2, LOW);
  digitalWrite(led3, LOW);
}

void loop() {
  if (Serial.available() > 0) {


  char statusLed = Serial.read();

  
  if (statusLed == '1')
  {
    if(digitalRead(led1) == LOW)
    {
      digitalWrite(led1, HIGH);
    }else {
      digitalWrite(led1, LOW);
    } 
  }

  if (statusLed == '2')
  {
    if(digitalRead(led2) == LOW)
    {
      digitalWrite(led2, HIGH);
    } else 
    {
      digitalWrite(led2, LOW);
    } 
  }

  if (statusLed == '3')
  {
    if(digitalRead(led3) == LOW)
    {
      digitalWrite(led3, HIGH);
    } else 
    {
      digitalWrite(led3, LOW);
    } 
  }

   
  if (statusLed == '4') {
    digitalWrite(led1, LOW);
    digitalWrite(led2, LOW);
    digitalWrite(led3, LOW);

  }

  }
}
