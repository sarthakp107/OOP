import java.util.Arrays;

public class missingnumber {
    public static void main(String[] args) {
        int[] arr = {3,0,1,2};
        // int[] arr = {3,5,2,1,4};

        sort(arr);
        System.out.println(Arrays.toString(arr));

    }



    public int missingNumber(int[] arr ){
        int i = 0;
        while(i< arr.length + 1){
            int correctIndex = arr[i] - 1;
            if(arr[i] != arr[correctIndex]){
                swap(arr, i , correctIndex);
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
