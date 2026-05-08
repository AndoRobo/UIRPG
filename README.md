# UIRPG
# UI RPG Game – Unity 6

## Projekta apraksts

Spēlē spēlētājs cīnās pret dažādiem pretiniekiem caur UI interfeisu. Pēc katra spēlētāja uzbrukuma pretinieks automātiski uzbrūk spēlētājam. Ja pretinieks nomirst, tiek izveidots jauns pretinieks un cīņa turpinās. Ja spēlētājs nomirst, spēle beidzas.

Spēlē ir realizēta:

* UI kaujas sistēma
* Battle log sistēma
* Vairāki pretinieki
* Vairāki ieroči
* Weapon selection sistēma
* Enemy image preview sistēma

# OOP principu izmantošana

## 1. Mantošana (Inheritance)

Tika izveidota bāzes klase `Character`, no kuras manto:

* `Player`
* `Enemy`

Papildus tika izmantota vēl viena mantošanas sistēma:

* `Weapon`

  * `BasicWeapon`
  * `ChargeWeapon`
  * `HeavyWeapon`

Tas ļauj atkārtoti izmantot kopīgu funkcionalitāti un organizēt kodu strukturēti.

## 2. Enkapsulācija (Encapsulation)

Projektā tika izmantoti getter un setter piemēri.

Piemērs:

public float Health
{
    get { return health; }
    set { health = Mathf.Max(0, value); }
}

Tika izmantoti private lauki un publiskas properties, lai kontrolētu pieeju datiem.

## 3. Polimorfisms (Polymorphism)

### Override piemēri

Tika izmantota `Attack()` funkcijas pārrakstīšana (`override`) klasēs:

* `Player`
* `Enemy`

Tika izmantota arī `GetDamage()` funkcijas pārrakstīšana dažādiem ieroču tipiem.

### Overload piemēri

Tika realizētas pārslogotas (`overload`) funkcijas:

GetHit(float damage)
GetHit(Weapon weapon)


## 4. Abstrakcija (Abstraction)

Tika izveidota abstrakta klase `Weapon`.

Klasē tika izmantota:

* viena parasta metode:

ShowWeapon()

* viena abstrakta metode:

GetDamage()

No šīs klases manto:

* `BasicWeapon`
* `ChargeWeapon`
* `HeavyWeapon`


# Papildus uzdevumi

## 1. Divi dažādi pretinieki

Spēlē ir vairāki pretinieki ar dažādiem uzbrukumiem un statistiku.

## 2. Trīs ieroču tipi

Spēlētājs var izvēlēties starp:

* Basic Weapon
* Charge Weapon
* Heavy Weapon

Katram ierocim ir atšķirīga damage sistēma.




