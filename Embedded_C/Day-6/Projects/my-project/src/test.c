#include<avr/io.h>
#include<util/delay.h>

#define LED_PIN PD2 // port D pin set to 4
#define LED_PIN1 PD5
#define LED_PIN2 PD7
// #define BUTTON_PIN PD2 // port D pin set to 2

int main()
{
   
    DDRD |= (1<<LED_PIN);
    DDRD |= (1<<LED_PIN1);
    DDRD |= (1<<LED_PIN2);

    PORTD |= (1<<LED_PIN);
    _delay_ms(500);
    PORTD &= ~(1<<LED_PIN);

    PORTD &= ~(1<<LED_PIN1);
     _delay_ms(500);
    PORTD |= (1<<LED_PIN1);
  
    while(1)
    {
      PORTD ^= (1<<LED_PIN2);
      _delay_ms(500);
       
    }
    
}