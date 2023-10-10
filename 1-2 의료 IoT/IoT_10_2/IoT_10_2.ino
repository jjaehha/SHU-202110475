void setup() {
Serial.begin(9600);
int oddnumber[10];
 int i=0;
while(i<=10) {
oddnumber[i] = (i*2)+1;
i++;
}
int count = 0 ;
int j=0;
while(j<10) {
count = count + oddnumber[j];
j++;
}
Serial.println(count);
}
void loop() {
} 
