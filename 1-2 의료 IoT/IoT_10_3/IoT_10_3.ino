void setup() {
Serial.begin(9600);
int evennumber[100];
for(int i=0; i<100; i++){
evennumber[i] = (i+1)*2;
}int count = 0;
for(int i=0; i<100; i++){
count = count + evennumber[i];
}
Serial.println(count);
}
void loop() {
}
