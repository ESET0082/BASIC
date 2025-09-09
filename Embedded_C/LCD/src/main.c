#include <Arduino.h>
#include<avr/io.h>
#include<util/delay.h>

#define DATA_PIN7 PD7
#define DATA_PIN6 PB0
#define DATA_PIN5 PB1
#define DATA_PIN4 PB2
#define ENABLE PB3
#define DATA_RS PB4

void lcd_command(unsigned char cmd)
{
    PORTB&=~(1<<DATA_RS); //set RS=0 for command

    PORTB= (PORTB & 0xF0) | ((cmd>>4) & 0x0F);   //send higher nibble
}
void lcd_data(unsigned char data)
{

}
void lcd_init()
{

}
void lcd_print(char *str)
{

}

void main()
{
     
}