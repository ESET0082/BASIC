#ifndef HAL_GPIO_H
#define HAL_GPIO_H

#include <stdint.h>     
#include <avr/io.h>

#define INPUT 0
#define OUTPUT 1

void HAL_GPIO_INIT(volatile uint8_t *port, uint8_t pin, uint8_t mode);
void HAL_GPIO_WRITE(volatile uint8_t *port, uint8_t pin, uint8_t value);
void HAL_GPIO_TOGGLE(volatile uint8_t *port, uint8_t pin);          
uint8_t HAL_GPIO_READ(volatile uint8_t *port, uint8_t pin);
// }    

#endif // HAL_GPIO_H