### **// SELECTIONS 5**

int input = 845;



void setup()

{

  Serial.begin(9600);

  if (input == 0)

  {

    Serial.print("0");

  }

  else if (input < 0)

  {

    Serial.print("-1");

  }

  else if (input > 0)

  {

    Serial.print("1");

  }

}



### **// SELECTIONS 7**

char grade = 'A';



void setup()

{

  switch (grade)

  {

    Serial.print();

    case 'E':

    	Serial.print('Excellent');

    	break;

    case 'V':

    	Serial.print('Very Good');

    	break;

    case 'G':

    	Serial.print('Good');

    	break;

    case 'A':

    	Serial.print('Average');

    	break;

    case 'F':

    	Serial.print('Fail');

    	break;

    default:

    	Serial.print('No known allocation');

    	break;

  }

}





### **// LOOPS 2**

int number = 1;

int sum;



void setup()

{

 	Serial.begin(9600);

 	Serial.println("The first 10 natural numbers are: ");

 	while (number <= 10)

 	{

 		Serial.print(number);

 		Serial.print(' ');

 		sum += number;

 		number++;

 	}

 	Serial.println();

 	Serial.print("The sum is: ");

 	Serial.print(sum);

}

 



### **// LOOPS 8**

int rows = 5;

int columns = 5;

int currentColumn = 1;



void setup()

{

  Serial.begin(9600);

  for (int i = 0; i < rows; i++)

  {

    for (int j = 0; j < currentColumn; j++)

    {

      Serial.print(j);

    }

    for (int k = 0; k < columns - currentColumn; k++)

    {

      Serial.print('\*');

    }

    currentColumn++;

    Serial.println();

  }

}





### **// BASIC METHODS 1**

void setup() {

  Serial.begin(9600);

}



void loop() {

  PrintHello();

}



void PrintHello() {

  Serial.println("Welcome Friends!\\nHave a nice day!");

}





### **// BASIC METHODS 5**

String input = "Yermumgae";

char currentChar;

int spaceCount;

int totalLength;



void setup() {

  Serial.begin(9600);

  CountSpaces();

}



void loop() {

}



void CountSpaces() {

  // get length of string

  totalLength = input.length();

 

  // go over each char in string

  for (int i = 0; i < totalLength; i++)

  {

    // set currentChar

    currentChar = input\[i];

    if (currentChar == ' ')

    {

      // add one if space is found

      spaceCount++;

    }

  }

 

  // print out the result

  if (spaceCount == 1)

  {

    Serial.println("\\"" + input + "\\" contains " + spaceCount + " space.");

  }

  else if (spaceCount == 0)

  {

 

  Serial.println("\\"" + input + "\\" contains no spaces.");

  }

  else

  {

    Serial.println("\\"" + input + "\\" contains " + spaceCount + " spaces.");

  }

}





### **// BASIC METHODS 6**

int baseNumber = 4;

int exponent = 3;

int result;



void setup() {

  Serial.begin(9600);

  PowerTo(baseNumber, exponent);

}



void loop() {

 

}



void PowerTo(int baseNumber, int exponent) {

  result = baseNumber;

  for (int i = 0; i < exponent - 1; i++)

  {

    result \*= baseNumber;

  }

 

  Serial.print(baseNumber);

  Serial.print(" to the power of ");

  Serial.print(exponent);

  Serial.print(" is: ");

  Serial.print(result);

  Serial.println();

}





### **// Advanced Methods 1**

String input = "John";



void setup() {

  Serial.begin(9600);

  WelcomeUser(input);

}



void loop() {

}



void WelcomeUser(String input) {

  Serial.print("Welcome friend " + input + "!\\n Have a nice day!");

  Serial.println();

}





### **// Advanced Methods 2**

int numberOne = 8;

int numberTwo = 5;

int result;



void setup() {

  Serial.begin(9600);

  result = NumberSum(numberOne, numberTwo);

  Serial.println(String("The sum of the two numbers is ") + result);

}



void loop() {

}



int NumberSum(int numberOne, int numberTwo) {

  int result;

  result = numberOne + numberTwo;

  return result;

}





### **// ADVANVED METHODS 3**

String input = "why do you want to be so gay to me";

int spaceCount;



void setup() {

  Serial.begin(9600);

  spaceCount = CountSpaces(input);

 

  // print out the result

  if (spaceCount == 1)

  {

    Serial.println("\\"" + input + "\\" contains 1 space.");

  }

  else if (spaceCount == 0)

  {

  	Serial.println("\\"" + input + "\\" contains no spaces.");

  }

  else

  {

    Serial.println("\\"" + input + "\\" contains " + spaceCount + " spaces.");

  }

}



void loop() {

}



int CountSpaces(String input) {



  // define variables

  int totalLength;

  int spaceCount = 0;

  char currentChar;

 

  // get length of string

  totalLength = input.length();

 

  // go over each char in string

  for (int i = 0; i < totalLength; i++)

  {

    // set currentChar

    currentChar = input\[i];

    if (currentChar == ' ')

    {

      // add one if space is found

      spaceCount++;

    }

  }

  return spaceCount;

}





### **// ADVANCED METHODS 4**

int ground = 6;

int power = 3;

int output;



void setup()

{

  Serial.begin(300);

  output = PowerTo(ground, power);

  Serial.print(ground);

  Serial.print(" to the power of ");

  Serial.print(power);

  Serial.print(" is ");

  Serial.println(output);

}



void loop ()

{

 

}





int PowerTo(int ground, int power)

{

  int result = ground;

  for (int i = 1; i < power; i++)

  {

    result \*= ground;

  }

  return result;

}





### **// ADVANCED METHODS 6**

int input = 6;

int output;



void setup()

{

  Serial.begin(9600);

  output = Factorialize(input);

  Serial.print("The factorial of ");

  Serial.print(input);

  Serial.print(" is ");

  Serial.println(output);

}



void loop ()

{

 

}



int Factorialize(int input)

{

  int result = input;

  for (int i = input - 1; i > 0; i--)

  {

    result \*= i;

  }

  return result;

}





### **// ADVANCED METHODS 8**

int input = 6;

double output;



void setup()

{

  Serial.begin(300);

  output = ConvertFahrenheit(input);

  Serial.print(input);

  Serial.print(" degrees Celcius is ");

  Serial.print(output);

  Serial.println(" degrees Fahrenheit");

  Serial.println();

}



void loop ()

{

 

}





double ConvertFahrenheit(int input)

{

  double outupt;

  output = (input \* 1.8 + 32);

  return output;

}





### **// DIGITAL 1**

const byte interruptPin = 2;  // input pin that the interruption will be attached to

volatile int state = LOW;  // variable that will be updated in the ISR

volatile byte ledNr = 5;



void setup() {

  pinMode(5, OUTPUT);

  pinMode(6, OUTPUT);

  pinMode(7, OUTPUT);

  pinMode(interruptPin, INPUT\_PULLUP);

  attachInterrupt(digitalPinToInterrupt(interruptPin), blink, RISING);

}



void loop() {

  digitalWrite(5, LOW);

  digitalWrite(6, LOW);

  digitalWrite(7, LOW);

  digitalWrite(ledNr, HIGH);

}



void blink() {

  Serial.println("Click!");

  ledNr++;

  if (ledNr == 8)

  {

    ledNr = 5;

  }

}





## **// NON BLOCKING 3**

// vars for the button switch

const int buttonPin = 2;

bool lastButtonState = LOW;

bool currentButtonState = LOW;



// vars for the potentiometers

int valueR;

int valueG;

int valueB;

const int potR = A2;

const int potG = A1;

const int potB = A0;



// vars for the RGB LED

const int ledR = 9;

const int ledG = 11;

const int ledB = 10;



int fadeTime = 10000;

unsigned long ledStartTime;

unsigned long timeDifference;



void setup()

{

&nbsp; // beginning serial communication for troubleshooting

&nbsp; Serial.begin(9600);

&nbsp; 

&nbsp; // setting in- and outputs

&nbsp; pinMode(buttonPin, INPUT);

&nbsp; pinMode(potR, INPUT);

&nbsp; pinMode(potG, INPUT);

&nbsp; pinMode(potB, INPUT);

&nbsp; pinMode(ledR, OUTPUT);

&nbsp; pinMode(ledG, OUTPUT);

&nbsp; pinMode(ledB, OUTPUT);

}



void loop()

{

&nbsp; // switch for the button (a)

&nbsp; currentButtonState = digitalRead(buttonPin);

&nbsp; if (currentButtonState) {

&nbsp;   if (!lastButtonState) {

&nbsp;     lastButtonState = true;

&nbsp;     

&nbsp;     // reading potentiometers and mapping to RGB values (b,c)

&nbsp;	  valueR = map(analogRead(potR),0,1023,0,255);

&nbsp;	  valueG = map(analogRead(potG),0,1023,0,255);

&nbsp;	  valueB = map(analogRead(potB),0,1023,0,255);

&nbsp;     

&nbsp;     // writing values to the LED (c)

&nbsp;     analogWrite(ledR, valueR);

&nbsp;     analogWrite(ledG, valueG);

&nbsp;     analogWrite(ledB, valueB);

&nbsp;     

&nbsp;     // setting current time as LED start time (e)

&nbsp;	  ledStartTime = millis();

&nbsp;   }

&nbsp;  }

&nbsp;  else {

&nbsp;    lastButtonState = false;

&nbsp;  }

&nbsp; // small delay (f)

&nbsp; delay(20);

&nbsp; 

&nbsp; 

&nbsp; // turning off LED (fadeTime) seconds after pressing (d)

&nbsp; timeDifference = millis() - ledStartTime;

&nbsp; if (timeDifference >= fadeTime) {

&nbsp;   turnOffLED();

&nbsp; }

}



void turnOffLED() {

&nbsp; // writing '0' to all RGB channels will turn off the LED

&nbsp;     analogWrite(ledR, 0);

&nbsp;     analogWrite(ledG, 0);

&nbsp;     analogWrite(ledB, 0);

}







### **// PRACTISE EXAM**



// This is the sketch of Robbe Fransen

// First year MCT 2025-2026

// January 8th 2026



const int leftBtnPin = 2;

const int rightBtnPin = 13;

const int led5 = 51;

const int LED1 = 11;

const int LED2 = 10;

const int LED3 = 9;



int activeLED = LED2;

int currentActiveLED;



bool leftBtnIsTriggered = false;

bool rightBtnIsTriggered = false;



void setup()

{

  // start serial communication

  Serial.begin(9600);

 

 

  // define in and outputs

  pinMode(LED1, OUTPUT);

  pinMode(LED2, OUTPUT);

  pinMode(LED3, OUTPUT);

 

  pinMode(leftBtnPin, INPUT);

  pinMode(rightBtnPin, INPUT);

 

  // print name

  Serial.println("Robbe Fransen");

 

 

  // turn on middle LED

  digitalWrite(LED2, HIGH);

}



void loop()

{

  // check left button pin

  if (digitalRead(leftBtnPin))

  {

    if (!leftBtnIsTriggered)

    {

      Serial.println("left click!");

 

      activeLED = Move(true, activeLED);

 

      leftBtnIsTriggered = true;

    }

  }

  else

  {

    leftBtnIsTriggered = false;

  }

 

  // check right button pin

  if (digitalRead(rightBtnPin))

  {

    if (!rightBtnIsTriggered)

    {

      Serial.println("right click!");

 

      activeLED = Move(false, activeLED);

 

      rightBtnIsTriggered = true;

    }

  }

  else

  {

    rightBtnIsTriggered = false;

  }

}



int Move(bool moveLeft, int currentActiveLED)

{

  digitalWrite(currentActiveLED, LOW);

 

  // moving left

  if (moveLeft) {

    currentActiveLED++;

  	if (currentActiveLED == (LED1 + 1))

    {

      currentActiveLED = LED3;

      Serial.println("underflow");

    }

  }

 

  // moving right

  else if (!moveLeft) {

    currentActiveLED--;

    if (currentActiveLED == (LED3 - 1))

    {

      currentActiveLED = LED1;

      Serial.println("overflow");

    }

  }

  Serial.println(currentActiveLED);

 

  digitalWrite(currentActiveLED, HIGH);

  return currentActiveLED;

}





N

