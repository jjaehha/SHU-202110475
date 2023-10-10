void setup() {
Serial.begin(9600);
int evennumber[100];
 int i=0;
while(i<=100) {
evennumber[i] = (i+1)*2;
i++;
}
int count = 0 ;
int j=0;
while(j<100) {
count = count + evennumber[j];
j++;
}
Serial.println(count);
}
void loop() {
} 
