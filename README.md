# Object Pooling

## Kurzbeschreibung

## Zielplattform

## Screenshot
![Screenshot](Assets/MyGame/Screenshots/screenshot.png)

## Destroy vs Object Pooling

Destroy entfernt ein GameObject aus der Szene.  
Object Pooling löscht Objekte nicht endgültig, sondern deaktiviert sie und verwendet sie später wieder.

Bei Destroy werden Objekte immer wieder neu erzeugt und gelöscht.  
Bei Object Pooling werden mehrere Objekte vorbereitet, deaktiviert und später wieder aktiviert.

Object Pooling ist besonders sinnvoll, wenn viele ähnliche Objekte oft erzeugt und wieder entfernt werden, zum Beispiel Projektile, Gegner oder Partikel.
