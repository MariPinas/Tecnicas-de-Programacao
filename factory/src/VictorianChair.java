public class VictorianChair implements Chair {
    
    @Override
    public Boolean sitOn(){
        return true;
    }

    @Override
    public Integer pontos(){
        return 5;
    }

    @Override
    public void getDescricao(){
        System.out.println("Cadeira Vitoriana");
    } 
}
