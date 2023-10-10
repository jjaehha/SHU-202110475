void setup() {
Serial.begin(9600);
int oddnumber[10];
for(int i=0; i<10; i++){
oddnumber[i] = (i*2)+1;
}int count = 0;
for(int i=0; i<10; i++){
count = count + oddnumber[i];
}
Serial.println(count);
}
void loop() {
}
