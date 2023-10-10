void setup() {
Serial.begin(9600);
int oddnumber[100];
for(int i=0; i<100; i++){
oddnumber[i] = (i*2)+1;
}int count = 0;
for(int i=0; i<100; i++){
count = count + oddnumber[i];
}
Serial.println(count);
}
void loop() {
}
