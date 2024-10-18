1. **Ce este un viewport?**  
   Este regiunea dreptunghiulară a ferestrei în care este desenat obiectul.

2. **Ce reprezintă conceptul de frames per seconds din punctul de vedere al bibliotecii OpenGL?**  
   Afișează timpul, în milisecunde, necesar pentru a desena un cadru.

3. **Când este rulată metoda OnUpdateFrame()?**  
   Metoda OnUpdateFrame() este rulată la fiecare cadru nou.

4. **Ce este modul imediat de randare?**  
   Modul imediat în grafica computerizată este un model de proiectare a API-ului în bibliotecile grafice, în care apelurile clientului cauzează direct redarea obiectelor grafice pe ecran.

5. **Care este ultima versiune de OpenGL care acceptă modul imediat?**  
   Ultima versiune care acceptă acest mod este OpenGL 3.1.

6. **Când este rulată metoda OnRenderFrame()?**  
   Metoda este rulată la randarea obiectelor.

7. **De ce este nevoie ca metoda OnResize() să fie executată cel puțin o dată?**  
   Pentru a dimensiona ViewPortul conform ferestrei active.

8. **Ce reprezintă parametrii metodei CreatePerspectiveFieldOfView() și care este domeniul de valori pentru aceștia?**  
   ```csharp
   public static void CreatePerspectiveFieldOfView(float fovy, float aspect, float zNear, float zFar, out OpenTK.Matrix4 result);
   
   fovy - Unghiul câmpului vizual în direcția y (în radiani)( este zero, mai mic decât zero sau mai mare decât Math.PI)
   aspect -Raportul de aspect al vizualizării (lățime / înălțime)( este negativ sau zero)
   zNear -Distanța față de planul apropiat(este mai mare decat zFar)
   zFar- Distanța până la planul îndepărtat (este negativ sau zero)

