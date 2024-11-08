# IIS Automation Tool

---

### **→ [Clicca qui per scaricare l’ultima versione!](https://drive.google.com/file/d/15C7XP8-kj-J2JI62GUeQtEi-yHSj86QF/view?usp=sharing) ←**

## Cose da fare

- Aprire il programma sempre con i permessi di **amministratore** (dalla versione 1.1 dovrebbe già aprirsi in modalità amministratore, al massimo controllare che sia effettivamente così)
- Creare 2 workspace: uno per il CRM e uno per HDA
- Creare 2 applicazioni in IIS, una “PortalAuto” e l’altra “WSC4Auto”. Il website non è rilevante.

![image](https://github.com/user-attachments/assets/6c59461b-439b-48a5-bb6e-b66a16692eca)

## Guida (v1.0)

Scaricare il pacchetto e lanciare il programma.

Impostare i path per il CRM e HDA (in teoria dovrebbe ricordarseli in caso di chiusura del programma).

![image 1](https://github.com/user-attachments/assets/d83b3b8c-6035-4494-9f9a-e9368e06487e)

Aggiornare la configurazione dopo aver scelto l’environment e il progetto.

![image 2](https://github.com/user-attachments/assets/bb7cdd26-ddc9-4e71-a673-0c21e5fd18c5)

Successivamente, refreshare i pool oppure consultare i log.

![image 3](https://github.com/user-attachments/assets/210df665-f6bd-401b-a785-f14a6bd19184)

## Versione 1.1

Da questa versione sono stati aggiunti alcuni comandi in più (nell’immagine read only ma solo perché non ho voglia di compilare i campi):

![image 4](https://github.com/user-attachments/assets/d284350f-37b6-4a56-a3ef-69c374c953fc)

**Open Portal Error Log Tail**: apre uno script in Powershell che segue la coda degli error-log del portale;

**Open WSC4 Error Log Tail**: apre uno script in Powershell che segue la coda degli error-log del WSC;

**Open Portal**: apre sul browser predefinito il portale del progetto (così da non dover andare su IIS e fare tasto destro > sfoglia);

**Open WSC4**: apre sul browser predefinito il WSC4 del progetto.

### Avviso quando è disponibile una nuova versione

![image 5](https://github.com/user-attachments/assets/2db778e2-df78-48d0-a96a-a21794fe2d88)

### Riduci a icona che finisce nell’area notifiche

![image 6](https://github.com/user-attachments/assets/704df417-5e5b-4e0e-ae6e-7815e5a5d750)

![image 7](https://github.com/user-attachments/assets/3c1a7cc2-d162-4325-b8aa-7c5dea281e44)

### Errori in popup

![image 8](https://github.com/user-attachments/assets/90e5fc5c-0659-4c5d-8c35-f3a29686ac82)

### Successo popup

![image 9](https://github.com/user-attachments/assets/29b3286d-f29d-431c-aba3-de28d402e782)

### Separatore magico

![image 10](https://github.com/user-attachments/assets/8464f813-323c-46fd-a67b-cbe5969b0d01)

### Tolta la possibilità di espandere la finestra

![image 11](https://github.com/user-attachments/assets/880bd4f1-0820-4f9d-853d-ae7af4a50f8b)

## Versione 1.2

Aggiunti script che mancavano nelle versioni precedenti 🙂
