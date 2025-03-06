//lc442 find all duplicates in an array

import java.util.ArrayList;
import java.util.List;

public class lc442 {
    public static void main(String[] args) {
        
    }

    public List<Integer> findDuplicates(int[] nums) {
        
        int i= 0;
        while(i < nums.length){
        
            int correctIndex = nums[i] - 1;
            if(nums[i] != nums[correctIndex]){
                //swap
                swap(nums, i, correctIndex);
            }
            else{
                i++;
            }
        }

        //after sorting
        List<Integer> ans = new ArrayList<>();
        for(int j = 0 ; j < nums.length ; j++){
            if(nums[j] != j + 1){
                ans.add(nums[j]);
            }
        }
        return ans;
    }

    public static void swap(int[] arr , int first , int second){
        int temp = arr[first];
        arr[first] = arr[second];
        arr[second] = temp;
    }
}
