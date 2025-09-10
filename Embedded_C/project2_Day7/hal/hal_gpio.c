#include "hal_gpio.h"

void HAL_GPIO_INIT(volatile uint8_t *port, uint8_t pin, uint8_t mode) {
    if (mode == OUTPUT) {
        *port |= (1 << pin);  // Set pin as output
    } else {
        *port &= ~(1 << pin); // Set pin as input
    }
}

void HAL_GPIO_WRITE(volatile uint8_t *port, uint8_t pin, uint8_t value) {
    if (value) {
        *port |= (1 << pin);  // Set pin high
    } else {
        *port &= ~(1 << pin); // Set pin low
    }
}

void HAL_GPIO_TOGGLE(volatile uint8_t *port, uint8_t pin) {
    *port ^= (1 << pin); // Toggle pin state
}

uint8_t HAL_GPIO_READ(volatile uint8_t *port, uint8_t pin) {
    return (*port & (1 << pin)) != 0; // Read pin state
}   