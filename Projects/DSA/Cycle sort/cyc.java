import java.util.Arrays;

public class cyc{
    public static void main(String[] args) {
        int[] arr = {3,5,2,1,4};
        sort(arr);
        System.out.println(Arrays.toString(arr));
    }

    public static void sort(int[] arr){
        int i = 0; // index
        while(i < arr.length){
             int correctIndex =  arr[i] - 1;
             if(arr[i] != arr[correctIndex] ){
                swap(arr, i, correctIndex);
             }else{
                i++;
             }
        }
    }

    public static void swap(int[] arr , int first , int second){
        int temp = arr[first];
        arr[first] = arr[second];
        arr[second] = temp;

    }
}