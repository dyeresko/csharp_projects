#C:\Program Files\Git\bin
ls "C:\Users\Denis\Desktop\csprojects\\"
read projectName
if [ ! -d "C:\Users\Denis\Desktop\csprojects\\$projectName" ]; then
    dotnet new myconsole -o "C:\Users\Denis\Desktop\csprojects\\$projectName"
    code C:\\Users\\Denis\\Desktop\\csprojects\\$projectName -r
else
    code C:\\Users\\Denis\\Desktop\\csprojects\\$projectName -r
fi


