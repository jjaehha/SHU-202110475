void setup() {
Serial.begin(9600);
int oddnumber[100];
 int i=0;
while(i<=100) {
oddnumber[i] = (i*2)+1;
i++;
}
int count = 0 ;
int j=0;
while(j<100) {
count = count + oddnumber[j];
j++;
}
Serial.println(count);
}
void loop() {
} 
