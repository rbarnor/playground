# STARTING OUT

## INSTALLATION
1. Install nodejs from their website.
2. run: 
>  npm install -g @angular/cli

## Starting a new Project
> ng new <projectname>

## OPENING OR RUNNING OUR PROJECT
> cd <projectname>

> ng serve


## HOW TO STYLE A PROJECT WITH BOOTSTRAP.
1. To use bootstrap we need to install it first
> npm install boostrap@5 --save

2. Open the angular.json file:

```
"styles": [
    "node_modules/boostrap/dist/css/boostrap.css",
    "src/styles.css",

]
```

3. Re-run: To see your changes.
> ng serve