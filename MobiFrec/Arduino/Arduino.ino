#include <DFRobot_GP8403.h>
DFRobot_GP8403 dac1(&Wire,0x5D);
DFRobot_GP8403 dac2(&Wire,0x5F);

#include <Wire.h>
#include <EEPROM.h>

unsigned long previo, actual;

const int DIR_POT = 44;
void(* resetSoftware)(void) = 0;

void setup() {
  Wire.begin();
  Serial.begin(9600);
  while(dac1.begin()!=0){
    Serial.println("init error");
    delay(1000);
   }
  while(dac2.begin()!=0){
    Serial.println("init error");
    delay(1000);
  }
  Serial.println("init succeed");
 
  dac1.setDACOutRange(dac1.eOutputRange10V);//Set the output range as 0-10V
  //dac1.setDACOutVoltage(8000,1);//The DAC value for 3.5V output in OUT0 channel
  dac1.setDACOutVoltage(0,2);
  //dac1.setDACOutVoltage(8,2);
  
  Serial.println("init succeed");
  dac2.setDACOutRange(dac2.eOutputRange10V);//Set the output range as 0-10V
  dac2.setDACOutVoltage(0,2);
  //uint16_t dato = 4;
  //uint16_t cuatro = (uint16_t)(((float)dato / 100000) * 4095);
  //cuatro = cuatro<<4;
  //Serial.println(cuatro);
  
  //dac2.setDACOutVoltage(8000,0);//The DAC value for 3.5V output in OUT0 channel
  //delay(1000);
  //dac.store(); //Save the set 3.5V voltage inside the chip
}

void loop()
{
  int valores[5];//mensaje dividido en partes por _
  int numValores = 0;
  byte comando = 0;
  int valor0 = 0;
  int valor1 = 0;
  int valor2 = 0;
  int valor3 = 0;

  if (Serial.available() > 0)
  {
    String mensaje = Serial.readStringUntil('\n');
    //dividir mensaje
    numValores = 0;
    comando = mensaje[0]; //la primera letra es el comando
    mensaje = mensaje.substring(2);//quita el comando
    // Serial.print("la longitud del mensaje es: ");
    // byte size = sizeof(mensaje);
    // int longit = mensaje.length();
    // Serial.println(size);
    // Serial.println("la longitud del mensaje es: ");
    // Serial.println(longit);
    while (mensaje.length() > 0)
    {
      int indice = mensaje.indexOf('_');
      if (indice == -1) // No se encuentra
      {
        valores[numValores++] = mensaje.toInt();
        //Serial.println(valores[numValores-1]);
        break;
      }
      else
      {
        valores[numValores++] = mensaje.substring(0, indice).toInt();
        //Serial.println(valores[numValores-1]);
        mensaje = mensaje.substring(indice + 1);
      }
    }

    valor0 = valores[0];
    valor1 = valores[1];
    valor2 = valores[2];
    valor3 = valores[3];
    // Serial.println("este es el valor 0");
    // Serial.println(valor0);
    // Serial.println("este es el valor 1");
    // Serial.println(valor2);
    switch (comando) //el comando
    {
      case 'X':
        {    
          Serial.println("Reset");
          resetSoftware();
          break;
        }
      case 'S': //respuesta localización puerto serie
        {
          Serial.println("0");
          break;
        }
        case 'G': //respuesta localización puerto serie
        {
          escribirGanancia(valor0);
          break;
        }
        case 'D': //SE MUEVE EN LA POSICION DE X,Y
        { 
          PosicionGrados(valor0,valor1);
          Serial.println("Se ha movido el laser");
          break;
        }
        case 'L': //SIGUE UNA SERIE DE PUNTOS DE X E Y
        { 
          previo = micros();
          linea(valor0,valor1,valor2,valor3);
          actual = micros();
          Serial.print("La función se ha ejecutado en: ");
          Serial.print(actual - previo);
          Serial.println(" us ");
          break;
        }
        case 'R': //DESPLAZAMIENTO EN EL EJE X
        { 
          previo = micros();
          rectaX(valor0);
          actual = micros();
          Serial.print("La función se ha ejecutado en: ");
          Serial.print(actual - previo);
          Serial.println(" us ");
          break;
        }
        case 'C': //  PINTA UN CIRCULO
        { 
          previo = micros();
          circulo(valor0);
          actual = micros();
          Serial.print("La función se ha ejecutado en: ");
          Serial.print(actual - previo);
          Serial.println(" us ");
          break;
        }
         case 'B': //DESPLAZAMIENTO A UN PUNTO Y
        { 
          previo = micros();
          rectaY(valor0);
          actual = micros();
          Serial.print("La función se ha ejecutado en: ");
          Serial.print(actual - previo);
          Serial.println(" us ");
          break;
        }
         case 'A': //DESPLAZAMIENTO EJE X
        { 
          previo = micros();
          lineaX(valor0,valor1);
          actual = micros();
          Serial.print("La función se ha ejecutado en: ");
          Serial.print(actual - previo);
          Serial.println(" us ");
          break;
        }
         case 'P': //DESPLAZAMIENT0 EN PENDIENTE, DIAGONAL
        { 
          previo = micros();
          pendiente(valor0, valor1);
          actual = micros();
          Serial.print("La función se ha ejecutado en: ");
          Serial.print(actual - previo);
          Serial.println(" us ");
          break;
        }
      default:
        {
          break;
        }
    }
  }
}

void rectaX(int val0)
{
  int posicionX = 0;

  int signoX = val0;
    posicionX = 1000*(abs(signoX));
    //Serial.println(posicionX);
    //Serial.println(posicionY);
      if (signoX>=0){    // Se compara los signos
        dac2.setDACOutVoltage(posicionX,0);
        dac2.setDACOutVoltage(0,1);
      } else if (signoX<0){
        dac2.setDACOutVoltage(posicionX,1);
        dac2.setDACOutVoltage(0,0);
      } 
}

void rectaY(int val0)
{
  int posicionY = 0;

  int signoY = val0;
    posicionY = 1000*(abs(signoY));
    //Serial.println(posicionX);
    //Serial.println(posicionY);
    
      if (signoY>=0){    // Se compara los signos
        dac1.setDACOutVoltage(posicionY,0);
        dac1.setDACOutVoltage(0,1);
      } else if (signoY<0){
        dac1.setDACOutVoltage(posicionY,1);
        dac1.setDACOutVoltage(0,0);
      } 
}

void PosicionGrados(int val0, int val1)
{
  int posicionX = 0;
  int posicionY = 0;
  //double posicionY = 0;
  int signoX = val0;
  int signoY = val1;
    posicionX = 1000*(abs(signoX));
    posicionY = 1000*(abs(signoY));
    Serial.println(posicionX);
    Serial.println(posicionY);
      if ((signoX>=0) && (signoY>=0)){    // Se compara los signos
        dac2.setDACOutVoltage(posicionX,0);
        dac1.setDACOutVoltage(posicionY,0);
        dac1.setDACOutVoltage(0,1);
        dac2.setDACOutVoltage(0,1);
      } else if ((signoY>=0) && (signoX<0)){
        dac2.setDACOutVoltage(posicionX,1);
        dac1.setDACOutVoltage(posicionY,0);
        dac2.setDACOutVoltage(0,0);
        dac1.setDACOutVoltage(0,1);
      } else if((signoX>=0) && (signoY<0)){
        dac2.setDACOutVoltage(posicionX,0);
        dac1.setDACOutVoltage(posicionY,1);
        dac1.setDACOutVoltage(0,0);
        dac2.setDACOutVoltage(0,1);
      } else if ((signoX<0) && (signoY<0)) {
        dac2.setDACOutVoltage(posicionX,1);
        dac1.setDACOutVoltage(posicionY,1);
        dac1.setDACOutVoltage(0,0);
        dac2.setDACOutVoltage(0,0);
      } 
}

void circulo(int val0)  //FUNCION QUE PIDE EL RADIO PARA PINTAR LA CIRCUNFERENCIA
{
  //dac1.setDACOutVoltage(0,2);
  //dac2.setDACOutVoltage(0,2);
  int radio = 0;
  double angulo = 0;
  double posicionX = 0;
  double posicionY = 0;

  radio = 1000*(abs(val0));
  for (angulo=0; angulo<=6.283185307; angulo=angulo+1.047197551){  //ARDUINO TRABAJA CON RADIANES, BARRIDO DE 0 A 2PI 
    double posicionX = radio*cos(angulo);               //pi/4 = 0.785398163; pi/6 = 0.523598775; pi/3 = 1.047197551
    double posicionY = radio*sin(angulo);
    Serial.println(posicionX);
    Serial.println(posicionY);
    delay(500);
    if (posicionX>=0 && posicionY>=0){
      dac1.setDACOutVoltage(posicionY,0);
      dac2.setDACOutVoltage(posicionX,0);
      //delay(1000);
    }
    else if (posicionX<0 && posicionY>=0){
      dac2.setDACOutVoltage(0,0);
      dac1.setDACOutVoltage(abs(posicionY),0);
      dac2.setDACOutVoltage(abs(posicionX),1);
      delay(500);
    }
    else if (posicionX<0 && posicionY<0){
      dac1.setDACOutVoltage(0,0);
      dac1.setDACOutVoltage(abs(posicionY),1);
      dac2.setDACOutVoltage(abs(posicionX),1);
      delay(500);
    }
     else if (posicionX>=0 && posicionY<0){
      dac2.setDACOutVoltage(0,1);
      dac1.setDACOutVoltage(abs(posicionY),1);
      dac2.setDACOutVoltage(abs(posicionX),0);
      delay(500);
    }
    
    delay(10);
  }
}

void linea(int val0, int val1, int val2, int val3)
{
  //Declaracion de las posiciones X e Y del de los espejos, coordenadas
  double posicionX0 = 0;
  double posicionX1 = 0;
  double posicionY0 = 0;
  double posicionY1 = 0;
  
  double x0 = val0;
  double x1 = val1;
  double y0 = val2;
  double y1 = val3;

  Serial.println("lo que buscas es: ");
  Serial.println(x1);
  Serial.println(x0);
  //Calculo del voltaje a partir de los grados de entrada +-5º
  posicionX0 = 1000*(abs(x0));
  posicionX1 = 1000*(abs(x1));
  posicionY0 = 1000*(abs(y0));
  posicionY1 = 1000*(abs(y1));
  //Serial.println(posicionX0);
  //Serial.println(posicionX1);
  //Todas las posiciones a cero (0,0), (0,0)
  //dac1.setDACOutVoltage(0,2);
  //dac2.setDACOutVoltage(0,2);
  if(x0>=0 && x1>=0){     //Punto inicial y final positivos
    if (x0>x1){           // Si el punto inicial es mayor, recorro de más a menos
      for (int i = posicionX0; i>=posicionX1; i--){
        dac2.setDACOutVoltage(i,0);
        dac2.setDACOutVoltage(0,1);
        //delay(10);
      } 
    }else if(x0<x1){      // Si el punto inicial es mayor, el laser va de menos a más
      for (int i = posicionX0; i<=posicionX1; i++){
        dac2.setDACOutVoltage(i,0);
        dac2.setDACOutVoltage(0,1);
        //delay(10);
      }
    } 
    //analogWrite(positivoX,0);
  }else if (x0<0 && x1<0){ //Si los dos puntos son negativos
    if (x0<x1){
      for (int i = posicionX0; i>=posicionX1; i--){
        dac2.setDACOutVoltage(i,0);
      } 
    }else if(x0>x1){
      for (int i = posicionX0; i<=posicionX1; i++){
        dac2.setDACOutVoltage(i,1);
       //delay(10);
      }
    }
   // analogWrite(negativoX,0);
   // analogWrite(positivoX,0);
  }else if(x0<0 && x1>=0) {
    for (int i = posicionX0; i>=0; i--){
      dac2.setDACOutVoltage(i,1);
      dac2.setDACOutVoltage(0,0);
      //delay(10);
    } 
    for (int i = 0; i<=posicionX1; i++){
      dac2.setDACOutVoltage(i,0);
      dac2.setDACOutVoltage(0,1);
      //delay(10);
    }
  //analogWrite(negativoX,0);
 // analogWrite(positivoX,0);
  }else if(x0>=0 && x1<0) {
    for (int i = posicionX0; i>=0; i--){
      dac2.setDACOutVoltage(i,0);
      //delay(10);
    } 
    for (int i = 0; i<=posicionX1; i++){
      dac2.setDACOutVoltage(i,1);
      //delay(10);
    }
  //analogWrite(negativoX,0);
 // analogWrite(positivoX,0);
  }
  //posiciones de lineas de y
  
  if(y0>=0 && y1>=0){
    //dac2.setDACOutVoltage(0,1);
    if (y0>y1){
      for (int i = posicionY0; i>=posicionY1; i--){
        dac1.setDACOutVoltage(i,0);
        dac1.setDACOutVoltage(0,1);
        //delay(10);
      } 
    }else if(y0<y1){
      for (int i = posicionY0; i<=posicionY1; i++){
        dac1.setDACOutVoltage(i,0);
        dac1.setDACOutVoltage(0,1);
        //delay(10);
      }
    } 
    //analogWrite(positivoY,0);
  }else if (y0<0 && y1<0){
    if (y0<y1){
      for (int i = posicionY0; i>=posicionY1; i--){
        dac1.setDACOutVoltage(i,1);
        //delay(10);
        //Serial.println(i);
      } 
    }else if(y0>y1){
    for (int i = posicionY0; i<=posicionY1; i++){
        dac1.setDACOutVoltage(i,1);
       //delay(10);
    }
  }
    //analogWrite(negativoY,0);
    //analogWrite(positivoY,0);
  }else if(y0<0 && y1>=0) {
    for (int i = posicionY0; i>=0; i--){
      dac1.setDACOutVoltage(i,1);
      //delay(10);
    } 
    for (int i = 0; i<=posicionY1; i++){
      dac1.setDACOutVoltage(i,0);
      //delay(10);
    }
  //analogWrite(negativoY,0);
  //analogWrite(positivoY,0);
  }else if(y0>=0 && y1<0) {
    for (int i = posicionY0; i>=0; i--){
      dac1.setDACOutVoltage(i,0);
      //delay(10);
    } 
    for (int i = 0; i<=posicionY1; i++){
      dac1.setDACOutVoltage(i,1);
      //delay(10);
    }
  //analogWrite(negativoY,0);
  //analogWrite(positivoY,0);
  }
}

void lineaX(int val0, int val1)
{
  //Declaracion de las posiciones X e Y del de los espejos, coordenadas
  double posicionX0 = 0;
  double posicionX1 = 0;
  
  double x0 = val0;
  double x1 = val1;

  //CALCULAMOS EL VOLTAJE PARA LOS GRADOS 
  posicionX0 = 1000*(abs(x0));
  posicionX1 = 1000*(abs(x1));
  //Serial.println(posicionX0);
  //Serial.println(posicionX1);
  //Todas las posiciones a cero (0,0), (0,0)
  //dac1.setDACOutVoltage(0,2);
  //dac2.setDACOutVoltage(0,2);
  if(x0>=0 && x1>=0){     //Punto inicial y final positivos
    if (x0>x1){           // Si el punto inicial es mayor, recorro de más a menos
      for (int i = posicionX0; i>=posicionX1; i--){
        dac2.setDACOutVoltage(i,0);
        //delay(10);
      } 
    }else if(x0<x1){      // Si el punto inicial es mayor, el laser va de menos a más
      for (int i = posicionX0; i<=posicionX1; i++){
        dac2.setDACOutVoltage(i,0);
        //delay(10);
      }
    } 
    //analogWrite(positivoX,0);
  }else if (x0<0 && x1<0){ //Si los dos puntos son negativos
    if (x0<x1){
      for (int i = posicionX0; i>=posicionX1; i--){
        dac2.setDACOutVoltage(i,0);
        //delay(10);
        //Serial.println(i);
      } 
    }else if(x0>x1){
      for (int i = posicionX0; i<=posicionX1; i++){
        dac2.setDACOutVoltage(i,1);
       //delay(10);
      }
    }
   // analogWrite(negativoX,0);
   // analogWrite(positivoX,0);
  }else if(x0<0 && x1>=0) {
    for (int i = posicionX0; i>=0; i--){
      dac2.setDACOutVoltage(i,1);
      //delay(10);
    } 
    for (int i = 0; i<=posicionX1; i++){
      dac2.setDACOutVoltage(i,0);
      //delay(10);
    }
  //analogWrite(negativoX,0);
 // analogWrite(positivoX,0);
  }else if(x0>=0 && x1<0) {
    for (int i = posicionX0; i>=0; i--){
      dac2.setDACOutVoltage(i,0);
      //delay(10);
    } 
    for (int i = 0; i<=posicionX1; i++){
      dac2.setDACOutVoltage(i,1);
      //delay(10);
    }
  }
}

void pendiente(int val0, int val1)    //ENTRAN LOS PUNTOS XY PARA TRAZAR LA PENDIENTE
{
  //Y = val1/val0
  //Serial.println(val1);
  double puntox, puntoy, incremento, posicionX, posicionY;
  puntox = abs(val0);
  puntoy = abs(val1);
  //Serial.println(puntoy);
  //Serial.println(incremento);
  posicionX = 1000*abs(puntox);   //EL DAC TIENE UNA SALIDA DE CERO A 10.000, TRANSFORMO LOS GRADOS EN VOLTAJE (-10º - +10º)
  posicionY = 1000*abs(puntoy);
  double posicion = 0;
  //dac2.setDACOutVoltage(0,2);    //PONGO TODO EN EL ORIGEN
  //dac1.setDACOutVoltage(0,2);

  if (val0>=0 && val1>=0){          //SI SON GRADOS POSITIVOS
    if (puntoy>puntox){
      incremento = puntox/puntoy;   //EL INCREMENTO SIRVE PARA TRAZAR LOS PUNTOS DEL EJE CON LA DISTANCIA CORTA
      //dac2.setDACOutVoltage(0,1);
      //dac1.setDACOutVoltage(0,1);
      for (int i = 0; i<=posicionY; i++){
        posicion = posicion+incremento;  //CALCULO LOS PUNTOS
      // Serial.println(posicion);
        dac2.setDACOutVoltage(posicion,0);
        dac1.setDACOutVoltage(i,0);
      }
      posicion = 0;
    }else if (puntoy<puntox){
      incremento = puntoy/puntox;
      for (int i = 0; i<=posicionX; i++){
        posicion = posicion+incremento;
        dac2.setDACOutVoltage(i,0);
        dac1.setDACOutVoltage(posicion,0);
        //Serial.println(posicion);
        //Serial.println("pan");
      }
      posicion = 0;
    }else if (puntox==puntoy){
      for (int i = 0; i<=posicionX; i++){
        dac2.setDACOutVoltage(i,0);
        dac1.setDACOutVoltage(i,0);
        //Serial.println("pan");
      }
    }
  }  
  else if (val0>=0 && val1<0){
      //Serial.print("este es el punto y");
      //Serial.println(puntoy);
      if (puntoy>puntox){
      incremento = puntox/puntoy;
      for (int i = 0; i<=posicionY; i++){
        posicion = posicion+incremento;
      // Serial.println(posicion);
        dac2.setDACOutVoltage(posicion,0);
        dac1.setDACOutVoltage(i,1);
      }
      //posicion = 0;
    }else if (puntoy<puntox){
      incremento = puntoy/puntox;
      for (int i = 0; i<=posicionX; i++){
        posicion = posicion+incremento;
        dac2.setDACOutVoltage(i,0);
        dac1.setDACOutVoltage(posicion,1);
        //Serial.println(posicion);
        //Serial.println("pan");
      }
      //posicion = 0;
    }else if (puntox==puntoy){
      for (int i = 0; i<=posicionX; i++){
        dac2.setDACOutVoltage(i,0);
        dac1.setDACOutVoltage(i,1);
      }
    }
  }
   else if (val0<0 && val1>=0){
      //dac2.setDACOutVoltage(0,1);
      //dac1.setDACOutVoltage(0,1);
      //Serial.print("este es el punto y");
      //Serial.println(puntoy);
      if (puntoy>puntox){
      incremento = puntox/puntoy;
      for (int i = 0; i<=posicionY; i++){
        posicion = posicion+incremento;
      // Serial.println(posicion);
        dac2.setDACOutVoltage(posicion,1);
        dac1.setDACOutVoltage(i,0);
      }
      //posicion = 0;
    }else if (puntoy<puntox){
      incremento = puntoy/puntox;
      for (int i = 0; i<=posicionX; i++){
        posicion = posicion+incremento;
        dac2.setDACOutVoltage(i,1);
        dac1.setDACOutVoltage(posicion,0);
        //Serial.println(posicion);
        //Serial.println("pan");
      }
      //posicion = 0;
    }else if (puntox==puntoy){
      for (int i = 0; i<=posicionX; i++){
        dac2.setDACOutVoltage(i,1);
        dac1.setDACOutVoltage(i,0);
      }
    }
  }
   else if (val0<0 && val1<0){
      dac2.setDACOutVoltage(0,0);
      dac1.setDACOutVoltage(0,0);
      //Serial.print("este es el punto y");
      //Serial.println(puntoy);
      if (puntoy>puntox){
      incremento = puntox/puntoy;
      for (int i = 0; i<=posicionY; i++){
        posicion = posicion+incremento;
        //Serial.println(posicion);
        dac2.setDACOutVoltage(posicion,1);
        dac1.setDACOutVoltage(i,1);
      }
      //posicion = 0;
    }else if (puntoy<puntox){
      incremento = puntoy/puntox;
      for (int i = 0; i<=posicionX; i++){
        posicion = posicion+incremento;
        dac2.setDACOutVoltage(i,1);
        dac1.setDACOutVoltage(posicion,1);
        //Serial.println(posicion);
        //Serial.println("pan");
      }
      //posicion = 0;
    }else if (puntox==puntoy){
      for (int i = 0; i<=posicionX; i++){
        dac2.setDACOutVoltage(i,1);
        dac1.setDACOutVoltage(i,1);
      }
    }
  }

}


int leerGanancia()
{
  int r;
  Wire.requestFrom(DIR_POT, 1);
  while (Wire.available())
    r = Wire.read();
  return r;
}

void escribirGanancia(int valor)
{ 
  Serial.println("el valor es el siguiente");
  Wire.beginTransmission(DIR_POT);
  Wire.write(0);// RDAC RS SD 01 02 three dont care bits
  Wire.write(valor);// valor del potenciómetro
  Serial.println(valor);
  Wire.endTransmission();
  delay(100);
}
