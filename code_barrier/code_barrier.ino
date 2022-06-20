
//#include <Keypad.h>
#include <LiquidCrystal_I2C.h>
#include <Wire.h>

bool check_cua_dong = false;
bool check = false;
byte HT_MO = 42;
byte HT_DONG = 44;
byte mo_cua = 36;
byte dong_cua = 38;
byte brake = 40 ;

String doc_the;
//String biensosanh = "";
//String the_moi = "";
char* ket_qua;
char* str1;
char str2[200] = "";
const char the_save[] =  {
  "191246861091591571231451571591551431551571451591151471531571151251411232492532290" //tag2
  "19124686109159157123145157159157149151157159143159143155147157121149141155249132290" //tag3
  "1912468610915915712314515715315915514715515315911712311714112112315915124972290" //tag4
  "191246861091591571231451571591571591571451591511491211251511451591552492472290" //tag5
  "191246861091591571231451571531591551591431551531511591231511591431531471151472492432290" //tag6
  "19124686109159157123145157159157141145157145159123159141147145157249252290" //tag7
  "19124686109159157123145157159155157153157145159121159119155157151153117249292290" //tag8
  "1912468610915915712314515715915515714515912114911714515512314315524992290" //tag9
  "1912468610915915712314515715915515315715115911915911514315115911524972290" //tag10
  "19124686109159157123145157155159157141157141155159123157123145123121143249212290" //tag11
  "191246861091591571231451571591571511571491591451591211531591212492552290" //tag12
  "19124686109159157123145157155159155151157143141159153157151143149159119249112290" //tag13
  "191246861091591571231451571591571551531571591411591471551471491251211411492492532290" //tag14
  "1912468610915915712314515715515915314715914315911912115511711511724912290" //tag15
  "191246861091591571231451571591551571431591411571591211471491571151471431532492372290"//tag16
  "191246861091591571231451571591551471431571491591171191231171231171572492392290" //tag17
  "191246861091591571231451571591571551471591411531591491151251151191571511572492332290" //tag18
  "19124686109159157123145157159157147157159147159143149143145151115145249252290" //tag19
  "19124686109159157123145157159157143149157159145159141115145151143121143249192290" //tag20
  "191246861091591571231451571591551451411571491591151531511451511171491592492332290" //tag21
  "191246861091591571231451571591551531591411571591211191151231531511592492372290" //tag22
  "19124686109159157123145157159149143157159149159157115121149115149151249112290" // tag23
  "191246861091591571231451571591511571591511591171431511451551231472492392290" // tag24
  "19124686109159157123145157155159157145141159143141159141115153149143147143145249212290" //tag25
  "191246861091591571231451571591551451571491591171151591531591551532492290" //tag26
  "191246861091591571231451571551591571591411451591491591171531171471552492312290" //tag27
  "1912468610915915712314515715914515115715914515915511715315714714115315524932290" //tag28
  "1912468610915915712314515715915714514915715914515914114711914514312114311524972290" //tag29
  "191246861091591571231451571591451411571591411591531591411151411211551572492290" //tag30
  "19124686109159157123145157159157159145159149157145151125119125249212290" //tag31
  "19124686109159157123145157159155159153157159155159123143141149155145159249132290" // tag32
  "19124686109159157123145157159157145157159141159149141123147159123159121249192290" //tag33
  "1912468610915915712314515715915315915714915914315311515112112515924952290" //tag34
  "19124686109159157123145157159155143157159121119125117147143145249272290" //tag35
  "191246861091591571231451571551591411431591431591511471491171411491252492552290" //tag36
  "191246861091591571231451571591571491451571591531591431491511171411251492492372290" //tag37
  "19124686109159157123145157155159157151153159145159145153149123147159125115249172290" //tag38
};


void setup()
{

  Serial1.begin(19200);
  pinMode(HT_MO, INPUT);
  pinMode(HT_DONG, INPUT);
  pinMode(mo_cua, OUTPUT);
  pinMode(dong_cua, OUTPUT);
  pinMode(brake, OUTPUT);
  digitalWrite(mo_cua, LOW);
  digitalWrite(dong_cua, LOW);
  digitalWrite(brake, LOW);
  delay(1000);
  //KIEM_TRA_TRANG_THAI_CUA();

}

/************************************************************************** CHAY MO CUA **************************************************************************/
void run_mo()
{

  Serial1.end();
  digitalWrite(brake, HIGH);
  delay(1000);
  digitalWrite(mo_cua, HIGH);
  delay(6000);
  // digitalWrite(mo_cua, LOW);
  while (digitalRead(HT_MO));
  //  while (digitalRead(HT_MO) == HIGH)
  //  {
  //    while (digitalRead(HT_MO) == HIGH)
  //    {
  //      // Serial.println(" mo cua di");
  //    }
  //    delay(100);
  //  }
  digitalWrite(mo_cua, LOW);
  digitalWrite(brake, LOW);
  delay(3000);
}

/******************************************************DONG CUA************************************************************************************************/
void run_dong()
{
  digitalWrite(brake, HIGH);
  delay(1000);
  digitalWrite(dong_cua, HIGH);
  delay(6000);
  while (digitalRead(HT_DONG));

  digitalWrite(dong_cua, LOW);
  digitalWrite(brake, LOW);
  delay(1000);
  Serial1.begin(19200);
}

/************************************************************************** CHAY DONG KHAN CAP **************************************************************************/
void run_dong_khan_cap()
{
  digitalWrite(brake, HIGH);
  delay(1000);
  digitalWrite(dong_cua, HIGH);

  delay(400);
  while (digitalRead(HT_DONG) == HIGH && Serial1.available() <= 0)
  {
    while (digitalRead(HT_DONG) == HIGH && Serial1.available() <= 0)
    {

    }
    delay(100);
  }

  if (digitalRead(HT_DONG) == LOW)
  {
    digitalWrite(dong_cua, LOW);
    digitalWrite(brake, LOW);
    delay(3000);
  }
  else
  {
    Serial1.end();
    //  mo cua
    // Serial.println(" Co the tro lai");
    digitalWrite(dong_cua, LOW);
    digitalWrite(brake, LOW);
    delay(1000);

    run_mo_dung_khan_cap();

  }

}
/************************************************************************** CHAY MO CUA KHAN CAP **************************************************************************/
void run_mo_dung_khan_cap()
{
  digitalWrite(brake, HIGH);
  delay(500);
  digitalWrite(mo_cua, HIGH);
  //delay(3700);
  delay(300);
  // digitalWrite(mo_cua, LOW);
  while (digitalRead(HT_MO) == HIGH)
  {
    //Serial.println(" mo cua");
    while (digitalRead(HT_MO) == HIGH)
    {

    }
    delay(100);
  }

  digitalWrite(mo_cua, LOW);
  digitalWrite(brake, LOW);
  delay(3000);
  if (digitalRead(HT_MO) == LOW)
  {
    Serial1.begin(19200);
    while (Serial1.available() > 0)
    {
      Serial1.read();
      delay(100);
      // Serial.println(" Mo cua khi dong");
    }
  }

}
/************************************************************************** KIEM TRA TRANG THAI CUA **************************************************************************/
void KIEM_TRA_TRANG_THAI_CUA() 
{
  if ( digitalRead(HT_MO) != LOW && digitalRead(HT_DONG) == LOW )
  {

    check_cua_dong = true;
  }
  else if ( (  (digitalRead(HT_MO) != LOW) && (digitalRead(HT_DONG) != LOW) ) || (  (digitalRead(HT_MO) == LOW) && (digitalRead(HT_DONG) != LOW )  ) )
  {
    delay(1000);
    digitalWrite(brake, HIGH); // nha thang
    delay(2000);
    digitalWrite(dong_cua, HIGH);
    delay(1000);
    // while (digitalRead(HT_DONG) );

    while (digitalRead(HT_DONG) != LOW )
    {
      delay(300);
    }

    digitalWrite(dong_cua, LOW);
    digitalWrite(brake, LOW); // nha thang
    delay(500);
    check_cua_dong = true;
  }

}

void loop()
{
  String biensosanh = "";
  String  the_moi = "";
  if (check_cua_dong == true)
  {
    while ( Serial1.available() > 0 )
    {
      doc_the = Serial1.read();// doc kieu int ( dec)
      if (biensosanh != doc_the)
      {
        the_moi = the_moi + doc_the;
        biensosanh = doc_the;
      }
      check = true;
      delay(50);
    }

    if (check == true)
    {
      check = false;
      str1 = the_moi.c_str();
      strncpy(str2, str1, 100);
      ket_qua = strstr(the_save, str2);
      if (ket_qua != NULL)
      {
        the_moi = '\0';
        str1 = '\0';

        run_mo();
        //delay(2000);
        run_dong();
        //delay(1000);

        if (digitalRead(HT_DONG) == LOW)
        {
          str1 = '\0';
          the_moi = '\0';


        }
        else
        {
          the_moi = '\0';
          str1 = '\0';
        }
      }

    }

  }
  else
    KIEM_TRA_TRANG_THAI_CUA();

}
