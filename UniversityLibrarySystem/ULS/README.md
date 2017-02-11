#Use cases
```
                               +--------------------+
                               |                    |
                  +------------> 1 borrow an item   |
                  |            |                    |
                  |            +--------------------+
                  |
                  |            +--------------------+
                  |            |                    |
          customer+------------> 2 come back item   |
                  |            |                    |
                  |            +--------------------+
                  |
                  |            +--------------------+
                  |            |                    |
                  +------------> 3 comment an item  |
                               |                    |
                               +--------------------+



                               +--------------------+
                               |                    |
                  +------------> 4 remind deadline  |
                  |            |                    |
                  |            +--------------------+
            system|
                  |            +------------------------+
                  |            |                        |
                  +------------> 5 alert human operator |
                               |                        |
                               +------------------------+



                               +--------------------+
                               |                    |
             professor+--------> 6 request new item +---->student
                               |                    |
                               +--------------------+



                               +----------------------+
                               |                      |
                               | 7 register external  |
             employee+--------->                      |
                               |    customer          |
                               |                      |
                               +----------------------+
```
------------
#Class Diagram
```
                  costumer
                     +
        +------------+---------------+
        +                            +
external costumer          university costumer
                                     +
                             +-------+--------+
                             +                +
                          student         professor



                 item
                   +
      +--------------------------+
      +            +             +
  newspaper       book        journal
```
------------
##Implementazione use case 1
Un "costumer" vuole prendere in prestito un "item":

* se il costumer è external verifica che abbia pagato le tasse altrimenti.
* se il libro è stampato e il costumer è un universitario controlla che non ecceda il limite.
* controlla che l'item esaurito
